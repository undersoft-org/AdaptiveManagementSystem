﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Data.Store;

    public class ProductionalEventController
        : RemoteBusController<
            long,
            IEventStore,
            ProductionalEvent,
            ProductionalEvent,
            ServiceManager
        >
    {
        public ProductionalEventController(IServicer servicer) : base(servicer) { }
    }
}