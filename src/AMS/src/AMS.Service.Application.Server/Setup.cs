// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Application.Server;
using Undersoft.SDK.Service.Application.Server.Hosting;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Application.Server;

using Undersoft.AMS.Service.Clients.Abstractions;

public class Setup
{
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddApplicationServerSetup()
            .ConfigureApplicationServer()
            .AddDataServer<ICenterStore>()
            .AddDataServer<IEventStore>()
            .AddDataServer<IAccountStore>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseApplicationServerSetup(env)
            .UseServiceApplication()
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
