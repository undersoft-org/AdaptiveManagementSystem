// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Logistical.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Logistical;
    using Undersoft.SDK.Service.Data.Store;

    public class LogisticalEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            LogisticalEvent
        >
    {
        public LogisticalEventController(IServicer servicer) : base(servicer) { }
    }
}
