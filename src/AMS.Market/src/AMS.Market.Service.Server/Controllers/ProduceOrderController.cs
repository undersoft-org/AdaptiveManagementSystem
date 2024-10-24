// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Produces;

    public class ProduceOrderController
        : RemoteDataController<
            long,
            IMarketProducesStore,
            ProduceOrder,
            ProduceOrder,
            ServiceManager
        >
    {
        public ProduceOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
