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

    [Route($"api/data/market/StockTransaction")]
    public class StockTransactionController
        : ApiDataRemoteController<
            long,
            IMarketStocksStore,
            StockTransaction,
            StockTransaction,
            ServiceManager
        >
    {
        public StockTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
