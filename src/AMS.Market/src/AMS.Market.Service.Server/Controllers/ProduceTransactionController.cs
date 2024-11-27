// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Market.Produces;

    [Area("Data/Market/ProduceTransaction")]
    public class ProduceTransactionController
        : RemoteDataController<
            long,
            IMarketProducesStore,
            Transaction,
            ProduceTransaction,
            ServiceManager
        >
    {
        public ProduceTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
