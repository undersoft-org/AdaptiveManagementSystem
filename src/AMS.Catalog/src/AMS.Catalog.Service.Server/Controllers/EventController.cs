﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Clients.Abstractions;

    [Area("Bus/Catalog/Event")]
    public class EventController(IServicer servicer)
        : BusController<long, ICatalogEventStore, Event, Event, ServiceManager>(servicer)
    { }
}
