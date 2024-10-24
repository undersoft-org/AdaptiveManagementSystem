using Microsoft.AspNetCore.Mvc;


// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers
{
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus")]
    public class ParticipantEventController
        : BusController<
            long,
            IEventStore,
            Event,
            ParticipantEvent,
            ServiceManager
        >
    {
        public ParticipantEventController(IServicer servicer) : base(servicer) { }
    }
}
