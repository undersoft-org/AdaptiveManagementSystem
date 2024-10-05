// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;

using Undersoft.AMS.Document.Service.Application.ViewModels.Vaccination;

/// <summary>
/// The group validator.
/// </summary>
public class CertificateValidator : ViewValidator<Certificate>
{
    public CertificateValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Personal!.FirstName);
            }
        );
    }
}
