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
    using Undersoft.AMS.Service.Contracts.Market.Consumes;
    using Undersoft.SDK.Service.Data.Store;

    public class ConsumeEventController
        : RemoteBusController<
            long,
            IEventStore,
            Event,
            ConsumeEvent,
            ServiceManager
        >
    {
        public ConsumeEventController(IServicer servicer) : base(servicer) { }
    }
}
