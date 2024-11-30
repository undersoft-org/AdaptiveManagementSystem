﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Project.Service.Application.GUI.Compound.Presenting.NavMenu;

public class ProjectStocks : DataObject
{

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Items")]
    public string Items { get; set; } = "/presenting/market/stocks/items";
    public Icon ItemsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Offers")]
    public string Offers { get; set; } = "/presenting/market/stocks/offers";
    public Icon OffersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Orders")]
    public string Orders { get; set; } = "/presenting/market/stocks/orders";
    public Icon OrdersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Processes")]
    public string Processes { get; set; } = "/presenting/market/stocks/processes";
    public Icon ProcessesIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Transactions")]
    public string Transactions { get; set; } = "/presenting/market/stocks/transactions";
    public Icon TransactionsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/presenting/market/stocks/events";
    public Icon EventsIcon = new Icons.Regular.Size20.CalendarClock();
}

