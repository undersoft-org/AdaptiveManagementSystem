// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Logistic.Service.Server.Shipments.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;
    using Undersoft.SDK.Service.Data.Store;

    public class ShipmentEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            ShipmentEvent
        >
    {
        public ShipmentEventController(IServicer servicer) : base(servicer) { }
    }
}
