// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Service.Server;

using Undersoft.AMS.Service.Clients;
using Undersoft.AMS.Service.Contracts;
using Undersoft.AMS.Service.Infrastructure.Stores;

public class Setup
{
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddServerSetup()
            .ConfigureServer(
                true,
                [typeof(AccountStore), typeof(EventStore), typeof(EntryStore), typeof(ReportStore)],
                [typeof(ApplicationClient),
                    typeof(DocumentClient),
                    typeof(CatalogClient),
                    typeof(LogisticClient),
                    typeof(MarketClient)]
            )
            .AddAccessServer<AccountStore, Account>()
            .AddDataServer<IEntityStore>(
                DataServerTypes.Rest | DataServerTypes.OData
            )
            .AddDataServer<IEventStore>(
                DataServerTypes.All
            )
            .AddDataServer<IAccountStore>(
                DataServerTypes.All
            );
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseServerSetup(env)
            .UseServiceServer(["v1"], true)            
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
