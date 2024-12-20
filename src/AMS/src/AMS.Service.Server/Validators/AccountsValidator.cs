﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Operation.Command.Validator;
using Undersoft.SDK.Service.Server.Accounts;

namespace Undersoft.AMS.Service.Server.Validators;

/// <summary>
/// The accounts validator.
/// </summary>
public class AccountsValidator : CommandSetValidator<Account>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountsValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public AccountsValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationKind.Any,
            () =>
            {
                ValidateEmail(p => p.Contract.Credentials.Email);
            }
        );

        ValidationScope(
            OperationKind.Create | OperationKind.Upsert,
            () =>
            {
                ValidateRequired(p => p.Contract.Credentials.UserName);
                ValidateRequired(p => p.Contract.Credentials.Email);
                ValidateRequired(p => p.Contract.Credentials.Password);
            }
        );
        ValidationScope(
            OperationKind.Create,
            () =>
            {
                ValidateNotExist<IReportStore, Account>(
                    (cmd) =>
                        a =>
                            a.User != null
                                ? a.User.Email == cmd.Credentials.Email
                                    || a.User.UserName == cmd.Credentials.UserName
                                : false,
                    "Account already exists"
                );
            }
        );
        ValidationScope(
            OperationKind.Update | OperationKind.Change | OperationKind.Delete,
            () =>
            {
                ValidateRequired(p => p.Contract.Credentials.SessionToken);
                ValidateRequired(p => p.Contract.Credentials.Email);
                ValidateRequired(a => a.Contract.Id);
                ValidateExist<IReportStore, Account>(
                    (cmd) => a => a.User != null ? a.User.Email == cmd.Credentials.Email : false
                );
            }
        );
    }
}
