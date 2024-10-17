using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Logistic.Service.Server.Receptions.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Logistic.Receptions;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/ReceptionEvent")]
    public class ReceptionEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            ReceptionEvent
        >
    {
        public ReceptionEventController(IServicer servicer) : base(servicer) { }
    }
}
