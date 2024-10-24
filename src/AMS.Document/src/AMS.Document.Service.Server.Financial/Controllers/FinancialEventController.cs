﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Financial.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Financial;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class FinancialEventController
        : BusController<
            long,
            IEventStore,
            Event,
            FinancialEvent,
            ServiceManager
        >
    {
        public FinancialEventController(IServicer servicer) : base(servicer) { }
    }
}
