// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Clients.Abstractions;

    [Area("Bus/Market/Event")]
    public class EventController
        : BusController<
            long,
            IMarketEventStore,
            Event,
            Event,
            ServiceManager
        >
    {
        public EventController(IServicer servicer) : base(servicer) { }
    }
}
