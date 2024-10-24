// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Market.Produces;
    using Undersoft.SDK.Service.Data.Store;

    public class ProduceEventController
        : RemoteBusController<
            long,
            IEventStore,
            Event,
            ProduceEvent,
            ServiceManager
        >
    {
        public ProduceEventController(IServicer servicer) : base(servicer) { }
    }
}
