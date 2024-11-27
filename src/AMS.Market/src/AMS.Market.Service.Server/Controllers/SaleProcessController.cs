// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Market/SaleProcess")]
    public class SaleProcessController
        : RemoteDataController<long, IMarketSalesStore, Process, SaleProcess, ServiceManager>
    {
        public SaleProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
