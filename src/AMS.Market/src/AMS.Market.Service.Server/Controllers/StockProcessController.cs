﻿// ********************************************************
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
    using Undersoft.AMS.Service.Contracts.Market.Stocks;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Market/StockProcess")]
    public class StockProcessController
        : RemoteDataController<
            long,
            IMarketStocksStore,
            Process,
            StockProcess,
            ServiceManager
        >
    {
        public StockProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
