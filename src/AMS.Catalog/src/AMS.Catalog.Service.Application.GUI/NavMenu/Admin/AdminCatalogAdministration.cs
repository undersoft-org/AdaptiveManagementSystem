using Microsoft.FluentUI.AspNetCore.Components;
using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Application.GUI.View.Attributes;
using Undersoft.SDK.Service.Data.Object;

namespace Undersoft.AMS.Catalog.Service.Application.GUI.NavMenu.Admin;

public class AdminCatalogAdministration : DataObject
{
    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Accounts")]
    [IconRubric("AccountsIcon")]
    public string Accounts { get; set; } = "/admin/catalog/administration/accounts";

    public Icon AccountsIcon = new Icons.Regular.Size20.PersonAccounts();

    [Link]
    [MenuItem]
    [Extended]
    [DisplayRubric("Events")]
    [IconRubric("EventsIcon")]
    public string Events { get; set; } = "/admin/catalog/administration/events";

    public Icon EventsIcon = new Icons.Regular.Size20.TableLightning();
}

