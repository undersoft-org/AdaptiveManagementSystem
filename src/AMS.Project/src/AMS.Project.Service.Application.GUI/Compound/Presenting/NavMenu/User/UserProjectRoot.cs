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

namespace Undersoft.AMS.Project.Service.Application.GUI.Compound.Presenting.NavMenu.User;

public class UserProjectRoot : DataObject
{
    [MenuGroup]
    [Extended]   
    [Link("/presenting/user/panel")]
    public UserProjectPanel Panel { get; set; } = new UserProjectPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("StocksIcon")]
    public UserProjectStocks Stocks { get; set; } = new();
    public Icon StocksIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("SalesIcon")]
    public UserProjectSales Sales { get; set; } = new();
    public Icon SalesIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("RequestsIcon")]
    public UserProjectRequests Requests { get; set; } = new();
    public Icon RequestsIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    [IconRubric("ProgressIcon")]
    public UserProjectProgress Progress { get; set; } = new();
    public Icon ProgressIcon = new Icons.Regular.Size20.ReceiptSparkles();

    [MenuGroup]
    [Extended]
    [IconRubric("PlansIcon")]
    public UserProjectPlans Plans { get; set; } = new();
    public Icon PlansIcon = new Icons.Regular.Size20.ReceiptPlay();
}

