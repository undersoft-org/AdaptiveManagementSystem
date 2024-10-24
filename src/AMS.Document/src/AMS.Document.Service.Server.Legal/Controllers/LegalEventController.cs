// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Legal.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Legal;
    using Undersoft.SDK.Service.Data.Store;


    [Area("Bus")]
    public class LegalEventController
        : BusController<
            long,
            IEventStore,
            Event,
            LegalEvent,
            ServiceManager
        >
    {
        public LegalEventController(IServicer servicer) : base(servicer) { }
    }
}
