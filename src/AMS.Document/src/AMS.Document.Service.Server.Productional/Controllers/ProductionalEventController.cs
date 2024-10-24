// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Productional.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class ProductionalEventController
        : BusController<
            long,
            IEventStore,
            Event,
            ProductionalEvent,
            ServiceManager
        >
    {
        public ProductionalEventController(IServicer servicer) : base(servicer) { }
    }
}
