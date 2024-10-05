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

namespace Undersoft.AMS.Market.Service.Server.Consumes;

public class Setup
{
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddServerSetup()
            .ConfigureServer()
            .AddDataServer<IEntityStore>()
            .AddDataServer<IEventStore>()
            .AddDataServer<IAccountStore>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseServerSetup(env)
            .UseServiceServer()
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
