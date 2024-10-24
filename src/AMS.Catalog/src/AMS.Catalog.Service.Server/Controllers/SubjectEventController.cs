using Microsoft.AspNetCore.Mvc;
// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;
    using Undersoft.SDK.Service.Data.Store;

    [Area("Bus/Catalog")]
    public class SubjectEventController
        : RemoteBusController<long, IEventStore, Event, SubjectEvent, ServiceManager>
    {
        public SubjectEventController(IServicer servicer)
            : base(servicer) { }
    }
}
