// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Consumes;

    public class ConsumeOrderController
        : OpenDataRemoteController<
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
