using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Market.Produces;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/ProduceEvent")]
    public class ProduceEventController
        : ApiEventRemoteController<
            long,
            IEventStore,
            Event,
            ProduceEvent
        >
    {
        public ProduceEventController(IServicer servicer) : base(servicer) { }
    }
}
