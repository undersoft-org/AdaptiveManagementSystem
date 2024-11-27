// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;

    [Area("Bus/Logistic/InventoryEvent")]
    public class InventoryEventController(IServicer servicer)
        : RemoteBusController<
            long,
            ILogisticInventoryEventStore,
            Event,
            InventoryEvent,
            ServiceManager
        >(servicer) { }
}
