// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Consumes;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/ConsumeOffer")]
    public class ConsumeOfferController
        : ApiDataRemoteController<
            long,
            IMarketConsumesStore,
            ConsumeOffer,
            ConsumeOffer,
            ServiceManager
        >
    {
        public ConsumeOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
