using Microsoft.FluentUI.AspNetCore.Components;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service.Application.GUI
// ********************************************************

namespace Undersoft.AMS.Service.Application.GUI.Compound;

/// <summary>
/// The logo SCC.
/// </summary>
public class AMSLogo : Icon
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AMSLogo"/> class.
    /// </summary>
    public AMSLogo()
        : base(
            "Undersoft",
            IconVariant.Regular,
            IconSize.Custom,
            @"<svg width=""65"" height=""32"" version=""1.1"" viewBox=""0 0 17.707 10.053"" xmlns=""http://www.w3.org/2000/svg"">
                <g transform=""matrix(2.8454 0 0 3.6725 -59.978 -153.78)"" style=""stroke-width:.99997"">
                <text transform=""scale(1.1065 .90376)"" x=""18.878941"" y=""48.913036"" clip-rule=""evenodd"" style=""clip-rule:evenodd;font-family:sans-serif;font-size:11.771px;letter-spacing:-.51947px;line-height:73.8%;stroke-width:.71182;word-spacing:0px"" ill-rule=""evenodd"" xml:space=""preserve""><tspan x=""18.878941"" y=""48.913036"" rotate=""0 0 0 0"" style=""font-family:'Segoe UI';font-size:3.0476px;font-variant-caps:normal;font-variant-east-asian:normal;font-variant-ligatures:normal;font-variant-numeric:normal;font-weight:900;letter-spacing:-.51947px;line-height:73.8%;stroke-width:.71182;word-spacing:0px"">AMS</tspan></text>
                </g>
            </svg>"
        )
    { }
}
