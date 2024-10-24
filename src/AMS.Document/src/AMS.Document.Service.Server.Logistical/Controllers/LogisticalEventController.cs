﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Logistical.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Logistical;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class LogisticalEventController
        : BusController<
            long,
            IEventStore,
            Event,
            LogisticalEvent,
            ServiceManager
        >
    {
        public LogisticalEventController(IServicer servicer) : base(servicer) { }
    }
}
