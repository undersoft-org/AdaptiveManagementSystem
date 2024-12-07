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

public class AdminCatalogResources : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Files")]
    public string Files { get; set; } = "/admin/catalog/resources/files";
    public Icon FilesIcon = new Icons.Regular.Size20.Document();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Images")]
    public string Images { get; set; } = "/admin/catalog/resources/images";
    public Icon ImagesIcon = new Icons.Regular.Size20.Image();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Models")]
    public string Models { get; set; } = "/admin/catalog/resources/models";
    public Icon ModelsIcon = new Icons.Regular.Size20.Diagram();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    public string Events { get; set; } = "/admin/catalog/resources/events";
    public Icon EventsIcon = new Icons.Regular.Size20.Flash();
}

