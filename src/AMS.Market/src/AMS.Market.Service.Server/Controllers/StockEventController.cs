// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Market.Stocks;
    using Undersoft.SDK.Service.Data.Store;

    public class StockEventController
        : RemoteBusController<
            long,
            IEventStore,
            Event,
            StockEvent,
            ServiceManager
        >
    {
        public StockEventController(IServicer servicer) : base(servicer) { }
    }
}
