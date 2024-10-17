// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Logistic.Service.Server.Shipments.Validators
{
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;

    public class ShipmentProcessesValidator : CommandSetValidator<ShipmentProcess>
    {
        public ShipmentProcessesValidator(IServicer servicer) : base(servicer)
        {
            ValidationScope(
                OperationType.Any,
                () =>
                {
                    ValidateRequired(p => p.Contract.Name);
                    ValidateRequired(p => p.Contract.FullName);
                }
            );

        }
    }
}