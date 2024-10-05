// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Logistic.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Remote.Command.Validator;

namespace Undersoft.AMS.Logistic.Service.Application.Server.Validators
{
    using Undersoft.AMS.Logistic.Service.Contracts.Inventory;

    /// <summary>
    /// The contact validator.
    /// </summary>
    public class VaccineValidator : RemoteCommandValidator<Vaccine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientValidator"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public VaccineValidator(IServicer servicer) : base(servicer)
        {
            ValidationScope(
                OperationType.Any,
                () =>
                {
                    ValidateRequired(p => p.Model.Specification!.Name);
                    ValidateRequired(p => p.Model.Specification!.Dose);
                    ValidateRequired(p => p.Model.Safety!.ExpirationDays);
                    ValidateRequired(p => p.Model.Safety!.Temperature);
                    ValidateRequired(p => p.Model.Manufacturer!.Name);
                }
            );

        }
    }
}