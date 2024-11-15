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

namespace Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu;

public class Root : DataObject
{
    [MenuGroup]
    [Extended]
    [IconRubric("PanelIcon")]
    [Link("/presenting/panel")]
    public Panel Panel { get; set; } = new Panel();
    public Icon PanelIcon = new Icons.Regular.Size24.ChartMultiple();

    [MenuGroup]
    [Extended]
    [IconRubric("MarketIcon")]
    public Market Market { get; set; } = new Market();
    public Icon MarketIcon = new Icons.Regular.Size24.Syringe();
}

