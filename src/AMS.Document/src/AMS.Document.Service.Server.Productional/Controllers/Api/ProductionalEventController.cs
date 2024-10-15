using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Document.Service.Server.Productional.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/ProductionalEvent")]
    public class ProductionalEventController
        : ApiEventController<
            long,
            IEventStore,
            Event,
            ProductionalEvent
        >
    {
        public ProductionalEventController(IServicer servicer) : base(servicer) { }
    }
}
