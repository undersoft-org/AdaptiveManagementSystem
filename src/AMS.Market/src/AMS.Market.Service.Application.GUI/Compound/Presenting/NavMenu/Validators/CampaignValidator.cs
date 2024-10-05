// ********************************************************
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

using Undersoft.AMS.Market.Service.Application.ViewModels.Catalogs;

/// <summary>
/// The group validator.
/// </summary>
public class CampaignValidator : ViewValidator<Campaign>
{

    public CampaignValidator(IServicer servicer) : base(servicer)
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
