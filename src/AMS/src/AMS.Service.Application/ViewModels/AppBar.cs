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
    [DisplayRubric("Offers")]
    public string Offers { get; set; } = "/presenting/market/consumes/offers";
    public Icon OffersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [Extended]
    [DisplayRubric("Orders")]
    public string Orders { get; set; } = "/presenting/market/consumes/orders";
    public Icon OrdersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [Extended]
    [DisplayRubric("Processes")]
    public string Processes { get; set; } = "/presenting/market/consumes/processes";
    public Icon ProcessesIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [Extended]
    [DisplayRubric("Transactions")]
    public string Transactions { get; set; } = "/presenting/market/consumes/transactions";
    public Icon TransactionsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/presenting/market/consumes/events";
    public Icon EventsIcon = new Icons.Regular.Size20.CalendarClock();
}
