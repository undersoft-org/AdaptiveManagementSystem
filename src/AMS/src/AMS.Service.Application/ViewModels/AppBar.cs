// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC
// *************************************************

using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.SDK.Rubrics.Attributes;

namespace Undersoft.AMS.Service.Application.ViewModels;

public class AppBar : DataObject, IViewModel
{
    [Link]
    [Extended]
    [IconRubric("SystemIcon")]
    public string System { get; set; } = "/presenting/system/panel";
    public Icon SystemIcon = new Icons.Regular.Size20.System();

    [Link]
    [Extended]
    [IconRubric("MarketIcon")]
    public string Market { get; set; } = "/presenting/market/panel";
    public Icon MarketIcon = new Icons.Regular.Size20.BuildingRetailMoney();

    [Link]
    [Extended]
    [IconRubric("LogisticIcon")]
    public string Logistic { get; set; } = "/presenting/logistic/panel";
    public Icon LogisticIcon = new Icons.Regular.Size20.CubeSync();

    [Link]
    [Extended]
    [IconRubric("DocumentIcon")]
    public string Document { get; set; } = "/presenting/document/panel";
    public Icon DocumentIcon = new Icons.Regular.Size20.DocumentFolder();

    [Link]
    [Extended]
    [IconRubric("CatalogIcon")]
    public string Catalog { get; set; } = "/presenting/catalog/panel";
    public Icon CatalogIcon = new Icons.Regular.Size20.AppsListDetail();
}
