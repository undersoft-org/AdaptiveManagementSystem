// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.User.Market;
using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.User;

public class UserMarket : DataObject
{
    [MenuGroup]
    [Extended]
    public UserMarketSales Stocks { get; set; } = new UserMarketSales();
    public Icon StocksIcon = new Icons.Regular.Size20.CalendarClock();

    [MenuGroup]
    [Extended]
    public UserMarketSales Sales { get; set; } = new UserMarketSales();
    public Icon SalesIcon = new Icons.Regular.Size20.CalendarClock();

    [MenuGroup]
    [Extended]
    public UserMarketSales Purchases { get; set; } = new UserMarketSales();
    public Icon PurchasesIcon = new Icons.Regular.Size20.CalendarClock();

    [MenuGroup]
    [Extended]
    public UserMarketSales Produces { get; set; } = new UserMarketSales();
    public Icon ProducesIcon = new Icons.Regular.Size20.CalendarClock();

    [MenuGroup]
    [Extended]
    public UserMarketSales Consumes { get; set; } = new UserMarketSales();
    public Icon ConsumesIcon = new Icons.Regular.Size20.CalendarClock();
}

