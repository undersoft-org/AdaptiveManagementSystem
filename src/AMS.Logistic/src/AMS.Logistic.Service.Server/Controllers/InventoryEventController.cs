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
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Data.Store;

    public class InventoryEventController
        : RemoteBusController<long, IEventStore, InventoryEvent, InventoryEvent, ServiceManager>
    {
        public InventoryEventController(IServicer servicer)
            : base(servicer) { }
    }
}
