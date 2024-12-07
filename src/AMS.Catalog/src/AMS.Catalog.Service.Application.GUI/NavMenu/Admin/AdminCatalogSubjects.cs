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

namespace Undersoft.AMS.Catalog.Service.Application.GUI.NavMenu.Admin;

public class AdminCatalogSubjects : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Elements")]
    public string Elements { get; set; } = "/admin/catalog/subjects/elements";
    public Icon ElementsIcon = new Icons.Regular.Size20.ListBarTree();


    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Procedures")]
    public string Procedures { get; set; } = "/admin/catalog/subjects/procedures";
    public Icon ProceduresIcon = new Icons.Regular.Size20.ChartMultiple();


    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Workflows")]
    public string Workflows { get; set; } = "/admin/catalog/subjects/workflows";
    public Icon WorkflowsIcon = new Icons.Regular.Size20.GanttChart();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Categories")]
    public string Categories { get; set; } = "/admin/catalog/subjects/categories";
    public Icon CategoriesIcon = new Icons.Regular.Size20.DataTreemap();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Groups")]
    public string Groups { get; set; } = "/admin/catalog/subjects/groups";
    public Icon GroupsIcon = new Icons.Regular.Size20.Group();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/admin/catalog/subjects/events";
    public Icon EventsIcon = new Icons.Regular.Size20.Flash();
}

