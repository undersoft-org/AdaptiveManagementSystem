using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Sales.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/SaleEvent")]
    public class SaleEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            SaleEvent
        >
    {
        public SaleEventController(IServicer servicer) : base(servicer) { }
    }
}
