// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Inventory.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class InventoryEventController
        : BusController<
            long,
            IEventStore,
            Event,
            InventoryEvent,
            ServiceManager
        >
    {
        public InventoryEventController(IServicer servicer) : base(servicer) { }
    }
}
