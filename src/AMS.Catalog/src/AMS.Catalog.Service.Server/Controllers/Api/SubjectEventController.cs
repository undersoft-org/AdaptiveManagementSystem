using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers.Api
{
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;
    using Undersoft.SDK.Service.Data.Store;

    [Route($"api/SubjectEvent")]
    public class SubjectEventController
        : ApiEventRemoteController<
            long,
            IEventStore,
            Event,
            SubjectEvent
        >
    {
        public SubjectEventController(IServicer servicer) : base(servicer) { }
    }
}
