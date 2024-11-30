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

namespace Undersoft.AMS.Catalog.Service.Application.GUI.Compound.Presenting.NavMenu.Admin;

public class AdminRoot : DataObject
{
    [MenuGroup]
    [Extended]
    [Link("/presenting/admin/panel")]
    public AdminPanel Panel { get; set; } = new AdminPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    public AdminMarket Market { get; set; } = new AdminMarket();
    public Icon MarketIcon = new Icons.Regular.Size24.Syringe();

    [MenuGroup]
    [Extended]
    public AdminLogistic Logistic { get; set; } = new AdminLogistic();
    public Icon LogisticIcon = new Icons.Regular.Size24.BoxMultiple();

    [MenuGroup]
    [Extended]
    public AdminDocument Document { get; set; } = new AdminDocument();
    public Icon DocumentIcon = new Icons.Regular.Size24.AppsListDetail();

    [MenuGroup]
    [Extended]
    public AdminCatalog Catalog { get; set; } = new AdminCatalog();
    public Icon CatalogIcon = new Icons.Regular.Size24.AppsListDetail();

    [MenuGroup]
    [Extended]
    public AdminAdministration Administration { get; set; } = new AdminAdministration();
    public Icon AdministrationIcon = new Icons.Regular.Size24.WindowDevTools();
}

