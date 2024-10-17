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
    using Undersoft.AMS.Service.Contracts.Market.Stocks;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/StockOffer")]
    public class StockItemController
        : ApiDataRemoteController<long, IMarketStocksStore, StockItem, StockItem, ServiceManager>
    {
        public StockItemController(IServicer servicer)
            : base(servicer) { }
    }
}
