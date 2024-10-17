﻿using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Purchases.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Market.Purchases;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/PurchaseEvent")]
    public class PurchaseEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            PurchaseEvent
        >
    {
        public PurchaseEventController(IServicer servicer) : base(servicer) { }
    }
}
