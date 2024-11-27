﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Logistic.Shipments;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Logistic/ShipmentProcess")]
    public class ShipmentProcessController
          : RemoteDataController<
            long,
            ILogisticShipmentsStore,
            Process,
            ShipmentProcess,
            ServiceManager
        >
    {
        public ShipmentProcessController(IServicer servicer)
            : base(
                servicer)
        { }
    }
}
