// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Shipments.Controllers
{
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;
    using Undersoft.SDK.Service.Data.Store;

    public class ShipmentEventController
        : BusController<
            long,
            IEventStore,
            Event,
            ShipmentEvent,
            ServiceManager
        >
    {
        public ShipmentEventController(IServicer servicer) : base(servicer) { }
    }
}
