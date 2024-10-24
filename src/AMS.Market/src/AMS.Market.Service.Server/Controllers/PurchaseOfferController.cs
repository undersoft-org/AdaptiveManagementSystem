// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Purchases;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Market")]
    public class PurchaseOfferController
        : RemoteDataController<
            long,
            IMarketPurchasesStore,
            PurchaseOffer,
            PurchaseOffer,
            ServiceManager
        >
    {
        public PurchaseOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
