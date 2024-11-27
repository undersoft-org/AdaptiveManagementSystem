// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.AMS.Service.Contracts.Market.Purchases;

    [Area("Bus/Market/PurchaseEvent")]
    public class PurchaseEventController
        : RemoteBusController<
            long,
            IMarketPurchasesEventStore,
            Event,
            PurchaseEvent,
            ServiceManager
        >
    {
        public PurchaseEventController(IServicer servicer) : base(servicer) { }
    }
}
