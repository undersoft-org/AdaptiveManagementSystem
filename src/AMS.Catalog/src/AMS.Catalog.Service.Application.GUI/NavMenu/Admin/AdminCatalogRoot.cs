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

namespace Undersoft.AMS.Catalog.Service.Application.GUI.NavMenu.Admin;

public class AdminCatalogRoot : DataObject
{
    [MenuGroup]
    [Extended]
    [IconRubric("PanelIcon")]
    [Link("/user/catalog/panel")]
    public AdminCatalogPanel Panel { get; set; } = new AdminCatalogPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("SubjectsIcon")]
    public AdminCatalogSubjects Subjects { get; set; } = new();
    public Icon SubjectsIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("ParticipantsIcon")]
    public AdminCatalogParticipants Participants { get; set; } = new();
    public Icon ParticipantsIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("ResourcesIcon")]
    public AdminCatalogResources Resources { get; set; } = new();
    public Icon ResourcesIcon = new Icons.Regular.Size20.ReceiptBag();

    [MenuGroup]
    [Extended]
    public AdminCatalogAdministration Administration { get; set; } = new AdminCatalogAdministration();
    public Icon AdministrationIcon = new Icons.Regular.Size24.WindowDevTools();
}

