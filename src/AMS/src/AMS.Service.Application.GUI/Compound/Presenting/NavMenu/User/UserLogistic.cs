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

namespace Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.User;

/// <summary>
/// The contacts.
/// </summary>
public class UserLogistic : DataObject
{
    [MenuItem]
    [Extended]    
    [DisplayRubric("Inventory")]
    public string Inventory { get; set; } = "/presenting/user/logistic/inventory";
    public Icon InventoryIcon = new Icons.Regular.Size20.Box();

    [MenuItem]
    [Extended]
    [DisplayRubric("Requests")]
    public string Requests { get; set; } = "/presenting/user/inventory/requests";
    public Icon RequestsIcon = new Icons.Regular.Size20.BoxArrowUp();

    [MenuItem]
    [Extended]
    [IconRubric("TrafficsIcon")]
    [DisplayRubric("Traffics")]
    public string Traffics { get; set; } = "/presenting/user/inventory/traffics";
    public Icon TrafficsIcon = new Icons.Regular.Size20.CubeSync();
}
