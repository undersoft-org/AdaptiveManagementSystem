// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/SaleProcess")]
    public class SaleProcessController
        : ApiDataRemoteController<long, IMarketSalesStore, SaleProcess, SaleProcess, ServiceManager>
    {
        public SaleProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
