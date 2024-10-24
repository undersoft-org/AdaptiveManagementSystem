using Microsoft.AspNetCore.Mvc;
// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class ResourceEventController
        : RemoteBusController<long, IEventStore, Event, ResourceEvent, ServiceManager>
    {
        public ResourceEventController(IServicer servicer)
            : base(servicer) { }
    }
}
