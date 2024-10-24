// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog;
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Bus/Catalog")]
    public class CatalogEventController
        : BusController<
            long,
            IEventStore,
            Event,
            CatalogEvent,
            ServiceManager
        >
    {
        public CatalogEventController(IServicer servicer) : base(servicer) { }
    }
}
