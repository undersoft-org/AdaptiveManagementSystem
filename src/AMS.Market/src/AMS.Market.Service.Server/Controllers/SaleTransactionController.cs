﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Sales;

    [Area("Data/Market")]
    public class SaleTransactionController
        : RemoteDataController<
            long,
            IMarketSalesStore,
            SaleTransaction,
            SaleTransaction,
            ServiceManager
        >
    {
        public SaleTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
