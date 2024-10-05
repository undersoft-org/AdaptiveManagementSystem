// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Logistic.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Logistic.Service.Server.Catalogs;

using Undersoft.AMS.Logistic.Service.Clients;
using Undersoft.AMS.Logistic.Service.Contracts;
using Undersoft.AMS.Logistic.Service.Contracts.Catalogs;
using Undersoft.AMS.Logistic.Service.Infrastructure.Stores;

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
                new[]
                {
                    typeof(EventStore),
                    typeof(EntryStore),
                    typeof(ReportStore)
                },
                  new[]
                {
                    typeof(ApplicationClient),
                    typeof(AccessClient)
                }
            )
            .AddDataServer<IEntityStore>(
                DataServerTypes.Rest | DataServerTypes.OData,
                builder =>
                    builder
                        .AddInvocations<Campaign>()
                        .AddInvocations<Manufacturer>()
                        .AddInvocations<Office>()
                        .AddInvocations<Vaccine>()
                        .AddInvocations<Supplier>()
                        .AddInvocations<Price>()
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
