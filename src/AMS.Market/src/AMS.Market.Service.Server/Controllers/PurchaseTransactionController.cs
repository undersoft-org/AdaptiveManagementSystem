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
    using Undersoft.AMS.Service.Contracts.Market.Purchases;

    [Area("Data/Market")]
    public class PurchaseTransactionController
        : RemoteDataController<
            long,
            IMarketPurchasesStore,
            PurchaseTransaction,
            PurchaseTransaction,
            ServiceManager
        >
    {
        public PurchaseTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
