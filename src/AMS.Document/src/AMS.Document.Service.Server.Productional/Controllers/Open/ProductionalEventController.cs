// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Productional.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Data.Store;

    public class ProductionalEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            ProductionalEvent
        >
    {
        public ProductionalEventController(IServicer servicer) : base(servicer) { }
    }
}
