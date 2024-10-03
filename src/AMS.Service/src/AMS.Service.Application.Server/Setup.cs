﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Application.Server;
using Undersoft.SDK.Service.Application.Server.Hosting;
using Undersoft.SDK.Service.Data.Event;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;

namespace Undersoft.AMS.Service.Application.Server;

using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts;
using Undersoft.AMS.Service.Contracts.Accounts;
using Undersoft.AMS.Service.Infrastructure.Stores;

/// <summary>
/// The setup.
/// </summary>
public class Setup
{
    /// <summary>
    /// Configures the services.
    /// </summary>
    /// <param name="srvc">The srvc.</param>
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddApplicationServerSetup()
            .ConfigureApplicationServer(
                true,
                new[] { typeof(EventStore), typeof(ReportStore), typeof(EntryStore) },
                new[]
                {
                    typeof(AccessClient),
                    typeof(DocumentClient),
                    typeof(CatalogClient),
                    typeof(LogisticClient),
                    typeof(MarketClient)
                }
            )
            .AddDataServer<ICenterStore>(
                DataServerTypes.All,
                builder =>
                    builder
                        .AddInvocations<Activity>()             
            )
            .AddDataServer<IEventStore>(
                DataServerTypes.All,
                builder => builder.AddInvocations<EventInfo>()
            )
            .AddDataServer<IAccountStore>(
                DataServerTypes.All,
                builder => builder.AddInvocations<Account>()
                                  .AddInvocations<AccountAddress>()
                                  .AddInvocations<AccountPersonal>()
                                  .AddInvocations<AccountProfessional>()
                                  .AddInvocations<AccountOrganization>()
                                  .AddInvocations<AccountSubscription>()
                                  .AddInvocations<AccountConsent>()
                                  .AddInvocations<AccountTenant>()
                                  .AddInvocations<AccountPayment>()
            );
    }

    /// <summary>
    /// Configures the specified application.
    /// </summary>
    /// <param name="app">The application.</param>
    /// <param name="env">The env.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseApplicationServerSetup(env)
            .UseServiceApplication()
            .UseMultitenancy()
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
