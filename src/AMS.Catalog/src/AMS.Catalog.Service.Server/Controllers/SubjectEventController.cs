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
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;

    [Area("Bus/Catalog/SubjectEvent")]
    public class SubjectEventController
        : RemoteBusController<long, ICatalogSubjectsEventStore, Event, SubjectEvent, ServiceManager>
    {
        public SubjectEventController(IServicer servicer)
            : base(servicer) { }
    }
}
