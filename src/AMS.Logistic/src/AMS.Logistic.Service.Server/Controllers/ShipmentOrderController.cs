﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;

    public class ShipmentOrderController
        : RemoteDataController<
            long,
            ILogisticShipmentsStore,
            ShipmentOrder,
            ShipmentOrder,
            ServiceManager
        >
    {
        public ShipmentOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
