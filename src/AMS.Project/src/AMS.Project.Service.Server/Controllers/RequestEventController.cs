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
    using Undersoft.AMS.Service.Contracts.Project.Requests;

    [Area("Bus/Project/RequestEvent")]
    public class PurchaseEventController
        : RemoteBusController<
            long,
            IProjectRequestsEventStore,
            Event,
            RequestEvent,
            ServiceManager
        >
    {
        public PurchaseEventController(IServicer servicer) : base(servicer) { }
    }
}
