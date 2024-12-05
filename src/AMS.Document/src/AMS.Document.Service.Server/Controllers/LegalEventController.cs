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
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.AMS.Service.Contracts.Document.Legal;

    [Area("Bus/Document/LegalEvent")]
    public class LegalEventController
        : RemoteBusController<
            long,
            IDocumentLegalEventStore,
            Event,
            LegalEvent,
            ServiceManager
        >
    {
        public LegalEventController(IServicer servicer) : base(servicer) { }
    }
}
