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

namespace Undersoft.AMS.Project.Service.Application.GUI.Compound.Presenting.NavMenu.Admin;

public class AdminProjectSales : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Offers")]
    public string Offers { get; set; } = "/presenting/admin/market/sales/offers";
    public Icon OffersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Orders")]
    public string Orders { get; set; } = "/presenting/admin/market/sales/orders";
    public Icon OrdersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Processes")]
    public string Processes { get; set; } = "/presenting/admin/market/sales/processes";
    public Icon ProcessesIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Transactions")]
    public string Transactions { get; set; } = "/presenting/admin/market/sales/transactions";
    public Icon TransactionsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/presenting/admin/market/sales/events";
    public Icon EventsIcon = new Icons.Regular.Size20.CalendarClock();
}

