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

namespace Undersoft.AMS.Market.Service.Application.GUI.Compound.Presenting.NavMenu.User;

public class UserMarketRoot : DataObject
{
    [MenuGroup]
    [Extended]   
    [Link("/presenting/user/panel")]
    public UserMarketPanel Panel { get; set; } = new UserMarketPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("StocksIcon")]
    public UserMarketStocks Stocks { get; set; } = new();
    public Icon StocksIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("SalesIcon")]
    public UserMarketSales Sales { get; set; } = new();
    public Icon SalesIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("PurchasesIcon")]
    public UserMarketPurchases Purchases { get; set; } = new();
    public Icon PurchasesIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    [IconRubric("ProducesIcon")]
    public UserMarketProduces Produces { get; set; } = new();
    public Icon ProducesIcon = new Icons.Regular.Size20.ReceiptSparkles();

    [MenuGroup]
    [Extended]
    [IconRubric("ConsumesIcon")]
    public UserMarketConsumes Consumes { get; set; } = new();
    public Icon ConsumesIcon = new Icons.Regular.Size20.ReceiptPlay();
}

