// ********************************************************
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

namespace Undersoft.AMS.Catalog.Service.Application.GUI.NavMenu;

public class CatalogParticipants : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [IconRubric("MembersIcon")]
    public string Members { get; set; } = "/catalog/participants/members";
    public Icon MembersIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [IconRubric("ContractorsIcon")]
    public string Contractors { get; set; } = "/catalog/participants/contractors";
    public Icon ContractorsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("EnvironmentsIcon")]
    public string Environments { get; set; } = "/catalog/participants/environments";
    public Icon EnvironmentsIcon = new Icons.Regular.Size20.CalendarClock();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/catalog/subjects/events";
    public Icon EventsIcon = new Icons.Regular.Size20.Flash();
}

