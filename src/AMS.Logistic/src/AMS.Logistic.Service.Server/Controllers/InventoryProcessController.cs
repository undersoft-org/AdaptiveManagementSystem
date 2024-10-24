// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Server.Controller;

    public class InventoryProcessController
        : RemoteDataController<
            long,
            ILogisticInventoryStore,
            InventoryProcess,
            InventoryProcess,
            ServiceManager
        >
    {
        public InventoryProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
