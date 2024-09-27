﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Market.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;

using Undersoft.AMS.Market.Service.Application.ViewModels.Vaccination;

/// <summary>
/// The contact validator.
/// </summary>
public class AppointmentValidator : ViewValidator<Appointment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppointmentValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public AppointmentValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateEmail(p => p.Model.Personal!.Email);
                ValidateRequired(p => p.Model.Personal!.Email);
                ValidateRequired(p => p.Model.Personal!.PhoneNumber);
                ValidateRequired(p => p.Model.Personal!.FirstName);
                ValidateRequired(p => p.Model.Personal!.LastName);
            }
        );

    }
}
