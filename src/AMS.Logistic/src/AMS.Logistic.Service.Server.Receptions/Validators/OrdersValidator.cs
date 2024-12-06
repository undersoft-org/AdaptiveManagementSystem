﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.AMS.Service.Contracts.Activities;
using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Logistic.Service.Server.Receptions.Validators
{
    public class OrdersValidator : CommandSetValidator<Order>
    {
        public OrdersValidator(IServicer servicer) : base(servicer)
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