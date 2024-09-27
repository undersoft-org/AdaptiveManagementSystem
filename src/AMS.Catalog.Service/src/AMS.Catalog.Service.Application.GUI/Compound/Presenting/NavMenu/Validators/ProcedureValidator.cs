// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Catalog.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;

using Undersoft.AMS.Catalog.Service.Application.ViewModels.Vaccination;

/// <summary>
/// The group validator.
/// </summary>
public class ProcedureValidator : ViewValidator<Procedure>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OfficeValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public ProcedureValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Term!.Dose);
            }
        );
    }
}
