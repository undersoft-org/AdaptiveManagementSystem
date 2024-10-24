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
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;

    [Area("Data/Catalog/Subjects")]
    public class WorkflowController
        : RemoteDataController<
            long,
            ICatalogSubjectsStore,
            Workflow,
            Workflow,
            ServiceManager
        >
    {
        public WorkflowController(IServicer servicer) : base(servicer) { }
    }
}
