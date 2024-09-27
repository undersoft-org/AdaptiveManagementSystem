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

using Undersoft.AMS.Catalog.Service.Application.ViewModels.Catalogs;

public class SupplierValidator : ViewValidator<Supplier>
{
    public SupplierValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Organization!.OrganizationFullName);
            }
        );
    }
}
