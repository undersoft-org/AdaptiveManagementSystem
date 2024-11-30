using Microsoft.FluentUI.AspNetCore.Components;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service.Application.GUI
// ********************************************************

namespace Undersoft.AMS.Catalog.Service.Application.GUI.Compound;

/// <summary>
/// The logo SCC.
/// </summary>
public class AMSCatalogLogo : Icon
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AMSCatalogLogo"/> class.
    /// </summary>
    public AMSCatalogLogo()
        : base(
            "Undersoft",
            IconVariant.Regular,
            IconSize.Custom,
            @"<svg width=""57"" height=""32"" version=""1.1"" viewBox=""0 0 15.528 10.053"" xmlns=""http://www.w3.org/2000/svg"">
                <g transform=""matrix(2.4897,0,0,3.6725,-52.463,-153.78)"" style=""stroke-width:.99997"">
                <text transform=""scale(1.2166 .82195)"" x=""17.169889"" y=""53.14254"" clip-rule=""evenodd"" style=""clip-rule:evenodd;font-family:sans-serif;font-size:10.706px;letter-spacing:-.47245px;line-height:73.8%;stroke-width:.64739;word-spacing:0px"" ill-rule=""evenodd"" xml:space=""preserve""><tspan x=""17.169889"" y=""53.14254"" rotate=""0 0 0 0"" style=""font-family:'Segoe UI';font-size:2.7718px;font-variant-caps:normal;font-variant-east-asian:normal;font-variant-ligatures:normal;font-variant-numeric:normal;font-weight:900;letter-spacing:-.47245px;line-height:73.8%;stroke-width:.64739;word-spacing:0px"">AMS</tspan></text>
                <text transform=""scale(1.263 .79175)"" x=""16.628584"" y=""55.947353"" style=""fill:#a2a2a2;font-family:'Segoe UI';font-size:.95915px;font-variant-caps:normal;font-variant-east-asian:normal;font-variant-ligatures:normal;font-variant-numeric:normal;font-weight:bold;letter-spacing:.29289px;line-height:125%;stroke-width:.62033;word-spacing:0px"" xml:space=""preserve""><tspan x=""16.628584"" y=""55.947353"" style=""fill:#a2a2a2;font-family:'Segoe UI';font-size:.95915px;font-variant-caps:normal;font-variant-east-asian:normal;font-variant-ligatures:normal;font-variant-numeric:normal;font-weight:bold;letter-spacing:.29289px;stroke-width:.62033"">catalog</tspan></text>
                </g>
            </svg>"
        )
    { }
}
