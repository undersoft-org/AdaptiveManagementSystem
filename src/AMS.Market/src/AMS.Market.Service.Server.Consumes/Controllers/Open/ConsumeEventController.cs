// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Consumes.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Market.Consumes;
    using Undersoft.SDK.Service.Data.Store;

    public class ConsumeEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            ConsumeEvent
        >
    {
        public ConsumeEventController(IServicer servicer) : base(servicer) { }
    }
}
