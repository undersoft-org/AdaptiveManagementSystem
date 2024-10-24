// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;

    [Area("Data/Logistic")]
    public class ShipmentTransactionController
        : RemoteDataController<
            long,
            ILogisticShipmentsStore,
            ShipmentTransaction,
            ShipmentTransaction,
            ServiceManager
        >
    {
        public ShipmentTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
