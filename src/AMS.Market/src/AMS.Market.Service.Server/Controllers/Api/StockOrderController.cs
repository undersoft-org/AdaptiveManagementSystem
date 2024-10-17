// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Stocks;

    [Route($"api/data/market/StockOrder")]
    public class StockOrderController
        : ApiDataRemoteController<long, IMarketStocksStore, StockOrder, StockOrder, ServiceManager>
    {
        public StockOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
