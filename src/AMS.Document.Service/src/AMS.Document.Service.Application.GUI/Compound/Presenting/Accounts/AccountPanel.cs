﻿using Microsoft.FluentUI.AspNetCore.Components;
// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Application.GUI.Models;
using Undersoft.SDK.Service.Application.GUI.View;
using Undersoft.SDK.Service.Application.GUI.View.Abstraction;

namespace Undersoft.AMS.Document.Service.Application.GUI.Compound.Access;

using Undersoft.AMS.Document.Service.Contracts;

public class AccountPanel
{
    public AccountPanel() { }

    public async Task Open(IViewPanel<Account> _panel)
    {
        IViewData<Account> data;
        if (_panel.Content != null)
            data = _panel.Content;
        else
            data = new ViewData<Account>(new Account(), OperationType.Any);

        data.EntryMode = EntryMode.Tabs;
        data.Width = "390px";

        await _panel.Show(
            data,
            (p) =>
            {
                p.Alignment = HorizontalAlignment.Right;
                p.Title = $"Account";
                p.PrimaryAction = "Ok";
                p.SecondaryAction = null;
                p.ShowDismiss = true;
            }
        );

        HandlePanel(_panel.Content);
    }

    /// <summary>
    /// </summary>
    /// <param name="result"></param>
    /// <TODO> Handle saving account panel</TODO>
    public void HandlePanel(IViewData<Account>? result) { }
}
