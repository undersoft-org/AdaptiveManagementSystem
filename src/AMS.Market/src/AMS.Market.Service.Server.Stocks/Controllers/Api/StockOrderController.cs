﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Stocks.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Stocks;

    [Route($"api/data/market/stocks/StockOrder")]
    public class StockOrderController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            StockOrder,
            ServiceManager
        >
    {
        public StockOrderController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Order
                                | Domain.Entities.Enums.ActivityType.Stock
                            )
                        ) > 0,
                }
            )
        { }
    }
}