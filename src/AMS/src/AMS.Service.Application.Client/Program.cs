using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   application: Undersoft.AMS.Service.Application.Client
// ********************************************************

using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Access;
using Undersoft.SDK.Service.Application.Access;
using Undersoft.SDK.Service.Application.GUI.Models;
using Undersoft.SDK.Service.Application.GUI.View.Abstraction;
using Undersoft.SDK.Service.Application.GUI.View.Access;
using Undersoft.SDK.Service.Data.Remote.Repository;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Application.Client;

using Undersoft.AMS.Service.Application.GUI.Compound.Access;
using Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;
using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Contracts;
using Undersoft.AMS.Service.Contracts.Accounts;
using Undersoft.SDK.Service.Application.GUI;
using Undersoft.SDK.Service.Application.GUI.View.Account;
using Undersoft.SDK.Service.Data.Event;
using Undersoft.SVC.Service.Application.GUI.Compound.Access;

/// <summary>
/// The program.
/// </summary>
public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        var manager = builder
            .Services.AddServiceSetup(builder.Configuration)
            .ConfigureServices()
            .Manager;

        await manager.UseServiceClients();

        builder.ConfigureContainer(
            manager.GetProviderFactory(),
            (services) =>
            {
                var reg = manager.GetRegistry();
                reg.AddAuthorizationCore()
                    .AddFluentUIComponents((o) => o.UseTooltipServiceProvider = true)
                    .AddViewServices()
                    .AddScoped<
                        IRemoteRepository<IAccountStore, Account>,
                        RemoteRepository<IAccountStore, Account>
                    >()
                    .AddScoped<
                        IRemoteRepository<IEventStore, EventInfo>,
                        RemoteRepository<IEventStore, EventInfo>
                    >()
                    .AddSingleton<AppearanceState>()
                    .AddScoped<AccessProvider<Account>>()
                    .AddScoped<AuthenticationStateProvider, AccessProvider<Account>>(sp =>
                        sp.GetRequiredService<AccessProvider<Account>>()
                    )
                    .AddScoped<IAccess, AccessProvider<Account>>(sp =>
                        sp.GetRequiredService<AccessProvider<Account>>()
                    )
                    .AddScoped<IAccessProvider<Account>, AccessProvider<Account>>(sp =>
                        sp.GetRequiredService<AccessProvider<Account>>()
                    )
                    .AddScoped<IAccessService<Account>, AccessProvider<Account>>(sp =>
                        sp.GetRequiredService<AccessProvider<Account>>()
                    )
                    .AddScoped<IValidator<IViewData<Credentials>>, AccessValidator>()
                    .AddScoped<IValidator<IViewData<Account>>, AccountValidator>()
                    .AddScoped<IValidator<IViewData<AccountAddress>>, AccountAddressValidator>()
                    .AddScoped<IValidator<IViewData<AccountPersonal>>, AccountPersonalValidator>()
                    .AddScoped<IValidator<IViewData<EventInfo>>, EventValidator>()
                    ;
                reg.MergeServices(services, true);
            }
        );

        var host = builder.Build();
        await host.RunAsync();
    }
}
