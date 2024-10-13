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
    using Undersoft.AMS.Service.Contracts.Catalog;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/CatalogEvent")]
    public class CatalogEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            CatalogEvent
        >
    {
        public CatalogEventController(IServicer servicer) : base(servicer) { }
    }
}
