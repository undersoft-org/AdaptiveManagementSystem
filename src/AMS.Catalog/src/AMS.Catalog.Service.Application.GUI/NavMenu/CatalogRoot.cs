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

namespace Undersoft.AMS.Catalog.Service.Application.GUI.NavMenu;

public class CatalogRoot : DataObject
{
    [MenuGroup]
    [Extended]
    [IconRubric("PanelIcon")]
    [Link("/catalog/panel")]
    public CatalogPanel Panel { get; set; } = new CatalogPanel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("SubjectsIcon")]
    public CatalogSubjects Subjects { get; set; } = new();
    public Icon SubjectsIcon = new Icons.Regular.Size20.ReceiptMoney();

    [MenuGroup]
    [Extended]
    [IconRubric("ParticipantsIcon")]
    public CatalogParticipants Participants { get; set; } = new();
    public Icon ParticipantsIcon = new Icons.Regular.Size20.ReceiptCube();

    [MenuGroup]
    [Extended]
    [IconRubric("ResourcesIcon")]
    public CatalogResources Resources { get; set; } = new();
    public Icon ResourcesIcon = new Icons.Regular.Size20.ReceiptBag();
}

