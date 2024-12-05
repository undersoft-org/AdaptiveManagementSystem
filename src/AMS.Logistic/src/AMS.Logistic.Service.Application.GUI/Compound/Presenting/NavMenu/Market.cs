// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.AMS.Logistic.Service.Application.GUI.Compound.Presenting.NavMenu.Markets;
using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Logistic.Service.Application.GUI.Compound.Presenting.NavMenu;

public class Market : DataObject
{
    [MenuGroup]
    [Extended]
    [IconRubric("StocksIcon")]
    public MarketStocks Stocks { get; set; } = new();
    public Icon StocksIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("SalesIcon")]
    public MarketSales Sales { get; set; } = new();
    public Icon SalesIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("PurchasesIcon")]
    public MarketPurchases Purchases { get; set; } = new();
    public Icon PurchasesIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    [IconRubric("ProducesIcon")]
    public MarketProduces Produces { get; set; } = new();
    public Icon ProducesIcon = new Icons.Regular.Size20.ReceiptSparkles();

    [MenuGroup]
    [Extended]
    [IconRubric("ConsumesIcon")]
    public MarketConsumes Consumes { get; set; } = new();
    public Icon ConsumesIcon = new Icons.Regular.Size20.ReceiptPlay();
}

