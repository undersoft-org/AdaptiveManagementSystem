// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Microsoft.AspNetCore.Mvc;
using Undersoft.AMS.Market.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts.Activities;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Application.Server.Controllers.Api.Market.Purchases
{
    [Route($"api/market/purchases/Offer")]
    public class OfferController
        : ApiDataRemoteController<long, IMarketPurchasesStore, Offer, Offer, ServiceManager>
    {
        public OfferController(IServicer servicer) : base(servicer) { }
    }
}


namespace Undersoft.AMS.Service.Application.Server.Controllers.Open.Market.Purchases
{
    public class OfferController
        : OpenDataRemoteController<long, IMarketPurchasesStore, Offer, Offer, ServiceManager>
    {
        public OfferController(IServicer servicer) : base(servicer) { }
    }
}