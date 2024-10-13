using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers.Api
{
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;

    [Route($"api/data/catalog/Archive")]
    public class ArchiveController
        : ApiDataRemoteController<
            long,
            ICatalogResourcesStore,
            Archive,
            Archive,
            ServiceManager
        >
    {
        public ArchiveController(IServicer servicer) : base(servicer) { }
    }
}
