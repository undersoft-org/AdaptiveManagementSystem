// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Market.Service.Server;

using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Clients.Abstractions;
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
        srvc.AddServerSetup()
            .ConfigureServer(
                true,
                [typeof(EventStore), typeof(EntryStore), typeof(ReportStore)],
                [
                    typeof(AccessClient),
                    typeof(MarketPurchasesClient),
                    typeof(MarketSalesClient),
                    typeof(MarketStocksClient),
                ]
            )
            .AddDataServer<IMarketCenterStore>(
                DataServerTypes.Rest | DataServerTypes.OData
            )
            .AddDataServer<IEventStore>(
                DataServerTypes.All
            )
            .AddDataServer<IAccountStore>(
                DataServerTypes.All
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
            .UseServiceServer(["v1"], true)
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
