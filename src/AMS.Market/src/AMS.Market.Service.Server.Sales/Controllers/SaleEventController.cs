// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Sales.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class SaleEventController
        : BusController<
            long,
            IEventStore,
            Event,
            SaleEvent,
            ServiceManager
        >
    {
        public SaleEventController(IServicer servicer) : base(servicer) { }
    }
}
