// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Commercial.Controllers
{
    using Undersoft.AMS.Service.Contracts.Document.Commercial;
    using Undersoft.SDK.Service.Data.Store;

    public class CommercialEventController
        : BusController<
            long,
            IEventStore,
            Event,
            CommercialEvent,
            ServiceManager
        >
    {
        public CommercialEventController(IServicer servicer) : base(servicer) { }
    }
}
