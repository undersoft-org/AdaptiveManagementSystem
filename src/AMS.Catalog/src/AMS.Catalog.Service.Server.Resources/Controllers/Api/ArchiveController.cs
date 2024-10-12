// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.AMS.Domain.Entities;
using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/catalog/resources/Archive")]
    public class ArchiveController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Resource,
            AMS.Service.Contracts.Resources.Archive,
            ServiceManager
        >
    {
        public ArchiveController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Resource>()
                {
                    Filter = p => (p.Type & ResourceType.Archive) > 0,
                }
            ) { }
    }
}
