﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Document.Service.Server;

using Undersoft.AMS.Service.Clients.Abstractions;

public class Setup
{
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddServerSetup()
            .ConfigureServer(true)
            .AddDataServer<IDocumentStore>()
            .AddDataServer<IDocumentEventStore>();            
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseServerSetup(env)
            .UseServiceServer(true, ["v1"])
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
