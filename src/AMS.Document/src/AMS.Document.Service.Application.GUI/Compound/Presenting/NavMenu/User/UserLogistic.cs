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

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Presenting.NavMenu.User;

/// <summary>
/// The contacts.
/// </summary>
public class UserLogistic : DataObject
{
    [MenuGroup]
    [Extended]
    public string Inventory { get; set; } = "/presenting/user/logistic/inventory";
    public Icon InventoryIcon = new Icons.Regular.Size20.BoxMultiple();

    [MenuGroup]
    [Extended]
    public string Deliveries { get; set; } = "/presenting/user/inventory/deliveries";
    public Icon DeliveriesIcon = new Icons.Regular.Size20.BoxMultipleArrowLeft();

    [MenuGroup]
    [Extended]
    public string Shipments { get; set; } = "/presenting/user/inventory/shipments";
    public Icon ShipmentsIcon = new Icons.Regular.Size20.BoxMultipleArrowRight();
}

