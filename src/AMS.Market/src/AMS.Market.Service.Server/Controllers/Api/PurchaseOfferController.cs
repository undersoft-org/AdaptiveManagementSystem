// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Produces;
    using Undersoft.AMS.Service.Contracts.Market.Purchases;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/PurchaseOffer")]
    public class PurchaseOfferController
        : ApiDataRemoteController<
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
