﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Produces;
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class ProduceProcessController
        : OpenDataRemoteController<
            long,
            IMarketProducesStore,
            ProduceProcess,
            ProduceProcess,
            ServiceManager
        >
    {
        public ProduceProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
