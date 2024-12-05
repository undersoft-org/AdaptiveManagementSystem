// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Document.Financial;

    [Area("Bus/Document/FinancialEvent")]
    public class FinancialEventController
        : RemoteBusController<
            long,
            IDocumentFinancialEventStore,
            Event,
            FinancialEvent,
            ServiceManager
        >
    {
        public FinancialEventController(IServicer servicer) : base(servicer) { }
    }
}
