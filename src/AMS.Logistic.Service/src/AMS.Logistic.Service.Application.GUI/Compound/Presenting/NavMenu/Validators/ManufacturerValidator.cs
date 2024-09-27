﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Logistic.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Logistic.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;

using Undersoft.AMS.Logistic.Service.Application.ViewModels.Catalogs;

/// <summary>
/// The group validator.
/// </summary>
public class ManufacturerValidator : ViewValidator<Manufacturer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OfficeValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public ManufacturerValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Name);
            }
        );
    }
}
