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

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Consumes;

    [Route($"api/data/market/ConsumeOrder")]
    public class ConsumeOrderController
        : ApiDataRemoteController<
            long,
            IMarketConsumesStore,
            ConsumeOrder,
            ConsumeOrder,
            ServiceManager
        >
    {
        public ConsumeOrderController(IServicer servicer)
            : base(servicer) { }
    }
}