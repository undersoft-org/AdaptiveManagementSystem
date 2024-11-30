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

namespace Undersoft.AMS.Project.Service.Application.GUI.Compound.Presenting.NavMenu.Admin;

public class AdminProjectRoot : DataObject
{
    [MenuGroup]
    [Extended]
    [Link("/presenting/admin/panel")]
    public AdminProjectPanel Panel { get; set; } = new AdminProjectPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("StocksIcon")]
    public AdminProjectStocks Stocks { get; set; } = new();
    public Icon StocksIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("SalesIcon")]
    public AdminProjectSales Sales { get; set; } = new();
    public Icon SalesIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("RequestsIcon")]
    public AdminProjectRequests Requests { get; set; } = new();
    public Icon RequestsIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    [IconRubric("ProgressIcon")]
    public AdminProjectProgress Progress { get; set; } = new();
    public Icon ProgressIcon = new Icons.Regular.Size20.ReceiptSparkles();

    [MenuGroup]
    [Extended]
    [IconRubric("PlansIcon")]
    public AdminProjectPlans Plans { get; set; } = new();
    public Icon PlansIcon = new Icons.Regular.Size20.ReceiptPlay();
}

