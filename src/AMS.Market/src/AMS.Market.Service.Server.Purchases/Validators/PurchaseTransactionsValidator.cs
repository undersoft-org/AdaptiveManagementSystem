﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Market.Service.Server.Purchases.Validators
{
    using Undersoft.AMS.Service.Contracts.Market.Purchases;

    public class PurchaseTransactionsValidator : CommandSetValidator<PurchaseTransaction>
    {
        public PurchaseTransactionsValidator(IServicer servicer) : base(servicer)
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