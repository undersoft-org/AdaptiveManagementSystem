// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Consumes;

    [Route($"api/data/market/ConsumeTransaction")]
    public class ConsumeTransactionController
        : ApiDataRemoteController<
            long,
            IMarketConsumesStore,
            ConsumeTransaction,
            ConsumeTransaction,
            ServiceManager
        >
    {
        public ConsumeTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
