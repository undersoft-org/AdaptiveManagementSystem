// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Legal.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Legal;
    using Undersoft.SDK.Service.Data.Store;

    public class LegalEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            LegalEvent
        >
    {
        public LegalEventController(IServicer servicer) : base(servicer) { }
    }
}
