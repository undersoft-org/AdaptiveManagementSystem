// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.Markets;
using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu;

public class Market : DataObject
{
    [MenuGroup]
    [Extended]
    public MarketStocks Stocks { get; set; } = new();
    public Icon StocksIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    public MarketSales Sales { get; set; } = new();
    public Icon SalesIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    public MarketPurchases Purchases { get; set; } = new();
    public Icon PurchasesIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    public MarketProduces Produces { get; set; } = new();
    public Icon ProducesIcon = new Icons.Regular.Size20.ReceiptSparkles();

    [MenuGroup]
    [Extended]
    public MarketConsumes Consumes { get; set; } = new();
    public Icon ConsumesIcon = new Icons.Regular.Size20.ReceiptPlay();
}

