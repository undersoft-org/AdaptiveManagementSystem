using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;
    using Undersoft.SDK.Service.Data.Store;

    public class ParticipantEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            ParticipantEvent
        >
    {
        public ParticipantEventController(IServicer servicer) : base(servicer) { }
    }
}
