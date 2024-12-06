﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Market.Service.Server.Stocks.Validators
{
    using Undersoft.AMS.Service.Contracts;

    public class ItemsValidator : CommandSetValidator<Item>
    {
        public ItemsValidator(IServicer servicer) : base(servicer)
        {
            ValidationScope(
                OperationKind.Any,
                () =>
                {
                    ValidateRequired(p => p.Contract.Name);
                    ValidateRequired(p => p.Contract.FullName);
                }
            );

        }
    }
}