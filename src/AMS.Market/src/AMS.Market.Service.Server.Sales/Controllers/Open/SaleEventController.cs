// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Sales.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Data.Store;

    public class SaleEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            SaleEvent
        >
    {
        public SaleEventController(IServicer servicer) : base(servicer) { }
    }
}
