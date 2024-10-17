using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Logistic.Service.Server.Inventory.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/InventoryEvent")]
    public class InventoryEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            InventoryEvent
        >
    {
        public InventoryEventController(IServicer servicer) : base(servicer) { }
    }
}
