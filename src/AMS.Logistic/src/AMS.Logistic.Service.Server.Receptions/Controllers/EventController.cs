// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Receptions.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus/Logistic/Receptions/Event")]
    public class EventController
        : BusController<
            long,
            IEventStore,
            Event,
            Event,
            ServiceManager
        >
    {
        public EventController(IServicer servicer) : base(servicer) { }
    }
}
