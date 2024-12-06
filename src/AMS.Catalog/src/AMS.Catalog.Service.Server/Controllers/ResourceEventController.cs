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
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;

    [Area("Bus/Catalog/ResourceEvent")]
    public class ResourceEventController
        : RemoteBusController<long, ICatalogResourcesEventStore, Event, ResourceEvent, ServiceManager>
    {
        public ResourceEventController(IServicer servicer)
            : base(servicer) { }
    }
}
