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

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Presenting.NavMenu.Admin;

/// <summary>
/// The contacts.
/// </summary>
public class AdminLogistic : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [IconRubric("StocksIcon")]
    [DisplayRubric("Stocks")]
    public string Stocks { get; set; } = "/presenting/admin/inventory/stocks";
    public Icon StocksIcon = new Icons.Regular.Size20.Box();

    [Link]
    [MenuItem]
    [Extended]
    [IconRubric("RequestsIcon")]
    [DisplayRubric("Requests")]
    public string Requests { get; set; } = "/presenting/admin/inventory/requests";
    public Icon RequestsIcon = new Icons.Regular.Size20.BoxArrowUp();

    [Link]
    [MenuItem]
    [Extended]
    [IconRubric("TrafficsIcon")]
    [DisplayRubric("Traffics")]
    public string Traffics { get; set; } = "/presenting/admin/inventory/traffics";
    public Icon TrafficsIcon = new Icons.Regular.Size20.CubeSync();
}

