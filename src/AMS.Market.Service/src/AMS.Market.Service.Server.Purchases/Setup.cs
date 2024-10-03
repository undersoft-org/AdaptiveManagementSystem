﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Market.Service.Server.Inventory;

using Undersoft.AMS.Market.Service.Contracts;
using Undersoft.AMS.Market.Service.Contracts.Inventory;
using Undersoft.AMS.Market.Service.Infrastructure.Stores;
using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Contracts.Market;

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
        srvc.AddServerSetup()
            .ConfigureServer(
                true,
                new[] { typeof(EventStore), typeof(EntryStore), typeof(ReportStore) },
                new[]
                {
                    typeof(MarketClient),
                    typeof(AccessClient)
                }
            )
            .AddDataServer<IEntityStore>(
                DataServerTypes.Rest | DataServerTypes.OData,
                builder =>
                    builder
                        .AddInvocations<Request>()
                        .AddInvocations<Item>()
                        .AddInvocations<Traffic>()
            )
            .AddDataServer<IEventStore>(
                DataServerTypes.All,
                builder => builder.AddInvocations<EventInfo>()
            )
            .AddDataServer<IAccountStore>(
                DataServerTypes.All,
                builder => builder.AddInvocations<Account>()
            );
    }

    /// <summary>
    /// Configures the specified application.
    /// </summary>
    /// <param name="app">The application.</param>
    /// <param name="env">The env.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseServerSetup(env)
            .UseServiceServer(new string[] { "v1" })
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
