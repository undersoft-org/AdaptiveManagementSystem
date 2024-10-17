﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Market.Service.Server.Stocks.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Stocks;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/stocks/StockOffer")]
    public class StockItemController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Item,
            StockItem,
            ServiceManager
        >
    {
        public StockItemController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Item>()
                {
                    Filter = p => (p.Type & Domain.Entities.Enums.ItemType.Stock) > 0,
                }
            ) { }
    }
}
