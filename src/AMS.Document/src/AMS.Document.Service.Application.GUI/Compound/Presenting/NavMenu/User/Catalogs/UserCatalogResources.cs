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

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Presenting.NavMenu.User.Catalogs;

public class UserCatalogResources : DataObject
{

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Offers")]
    public string Offers { get; set; } = "/presenting/user/logistic/purchases/offers";
    public Icon OffersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Orders")]
    public string Orders { get; set; } = "/presenting/user/logistic/purchases/orders";
    public Icon OrdersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Processes")]
    public string Processes { get; set; } = "/presenting/user/logistic/purchases/processes";
    public Icon ProcessesIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Transactions")]
    public string Transactions { get; set; } = "/presenting/user/logistic/purchases/transactions";
    public Icon TransactionsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/presenting/user/logistic/purchases/events";
    public Icon EventsIcon = new Icons.Regular.Size20.CalendarClock();
}

