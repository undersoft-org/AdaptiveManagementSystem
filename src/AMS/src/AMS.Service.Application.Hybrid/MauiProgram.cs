using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.FluentUI.AspNetCore.Components;
using System.Reflection;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Access;
using Undersoft.SDK.Service.Application.Access;
// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   application: Undersoft.AMS.Service.Application.Hybrid
// ********************************************************

using Undersoft.SDK.Service.Application.GUI;
using Undersoft.SDK.Service.Application.GUI.Models;
using Undersoft.SDK.Service.Application.GUI.View.Access;
using Undersoft.SDK.Service.Application.GUI.View.Abstraction;
using Undersoft.SDK.Service.Data.Remote.Repository;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Application.Hybrid;

using Undersoft.SDK.Service.Data.Event;
using Undersoft.AMS.Service.Application.GUI.Compound.Access;
using Undersoft.AMS.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;
using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Contracts;
using Undersoft.AMS.Service.Contracts.Accounts;
using Undersoft.AMS.Service.Contracts.Activities;
using EventInfo = SDK.Service.Data.Event.EventInfo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream(
                $"Undersoft.AMS.Service.Application.Hybrid."
                    + (
                        (DeviceInfo.Platform == DevicePlatform.Android)
                            ? "appsettings.android.json"
                            : "appsettings.json"
                    )
            );
        var config =
            (stream != null) ? new ConfigurationBuilder().AddJsonStream(stream).Build() : null;

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();

        builder.Services.AddFluentUIComponents();

        if (config != null)
            builder.Configuration.AddConfiguration(config);

        var manager = builder
            .Services.AddServiceSetup(config)
            .ConfigureServices(
                new[] { typeof(ApplicationClient), typeof(AccessClient), typeof(EventClient) }
            )
            .Manager;

        _ = manager.UseServiceClients();

        builder.ConfigureContainer(
            manager.GetProviderFactory(),
            (services) =>
            {
                var reg = manager.GetRegistry();
                reg.AddMauiBlazorWebView();
                reg.AddAuthorizationCore()
                    .AddFluentUIComponents((o) => o.UseTooltipServiceProvider = true)
                    .AddViewServices()
                    .AddSingleton<AppearanceState>()
                    .AddScoped<
                        IRemoteRepository<IAccountStore, Account>,
                        RemoteRepository<IAccountStore, Account>>()
                    .AddScoped<
                        IRemoteRepository<IEventStore, EventInfo>,
                        RemoteRepository<IEventStore, EventInfo>
                    >()                   
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
                    .AddScoped<IValidator<IViewData<EventInfo>>, EventValidator>()
                    ;
                reg.MergeServices(services, true);
            }
        );

        var host = builder.Build();
        return host;
    }
}
