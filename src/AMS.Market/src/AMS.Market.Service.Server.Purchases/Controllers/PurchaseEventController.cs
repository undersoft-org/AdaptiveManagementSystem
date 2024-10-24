// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Purchases.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Purchases;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class PurchaseEventController
        : BusController<
            long,
            IEventStore,
            Event,
            PurchaseEvent,
            ServiceManager
        >
    {
        public PurchaseEventController(IServicer servicer) : base(servicer) { }
    }
}
