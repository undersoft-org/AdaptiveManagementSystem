﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Sales;

    public class SaleTransactionController
        : OpenDataRemoteController<
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
