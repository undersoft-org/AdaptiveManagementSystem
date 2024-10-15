using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Document.Service.Server.Financial.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Document.Financial;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/FinancialEvent")]
    public class FinancialEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            FinancialEvent
        >
    {
        public FinancialEventController(IServicer servicer) : base(servicer) { }
    }
}
