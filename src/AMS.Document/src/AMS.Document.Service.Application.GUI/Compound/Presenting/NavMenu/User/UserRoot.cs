using Microsoft.FluentUI.AspNetCore.Components;





// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Presenting.NavMenu.User;

public class UserRoot : DataObject
{
    [MenuGroup]
    [Extended]
    [Link("/presenting/user/panel")]
    public UserPanel Panel { get; set; } = new UserPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    public UserMarket Market { get; set; } = new UserMarket();
    public Icon MarketIcon = new Icons.Regular.Size24.Syringe();

    [MenuGroup]
    [Extended]
    public UserLogistic Logistic { get; set; } = new UserLogistic();
    public Icon LogisticIcon = new Icons.Regular.Size24.BoxMultiple();

    [MenuGroup]
    [Extended]
    public UserDocument Document { get; set; } = new UserDocument();
    public Icon DocumentIcon = new Icons.Regular.Size24.AppsListDetail();

    [MenuGroup]
    [Extended]
    public UserCatalog Catalog { get; set; } = new UserCatalog();
    public Icon CatalogIcon = new Icons.Regular.Size24.AppsListDetail();
}

