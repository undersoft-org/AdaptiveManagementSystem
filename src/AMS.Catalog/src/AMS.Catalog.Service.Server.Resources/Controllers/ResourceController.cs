// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Resources")]
    public class ResourceController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Resource,
            Resource,
            ServiceManager
        >
    {
        public ResourceController(IServicer servicer)
            : base(servicer) { }
    }
}
