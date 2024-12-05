﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.AMS.Service.Contracts.Document.Logistical;

    [Area("Bus/Document/LogisticalEvent")]
    public class LogisticalEventController
        : RemoteBusController<
            long,
            IDocumentLogisticalEventStore,
            Event,
            LogisticalEvent,
            ServiceManager
        >
    {
        public LogisticalEventController(IServicer servicer) : base(servicer) { }
    }
}
