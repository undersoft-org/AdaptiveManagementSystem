// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Project.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Project.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.AMS.Service.Contracts.Project.Progress;

    [Area("Bus/Project/ProgressEvent")]
    public class ProduceEventController
        : RemoteBusController<
            long,
            IProjectProgressEventStore,
            Event,
            ProgressEvent,
            ServiceManager
        >
    {
        public ProduceEventController(IServicer servicer) : base(servicer) { }
    }
}
