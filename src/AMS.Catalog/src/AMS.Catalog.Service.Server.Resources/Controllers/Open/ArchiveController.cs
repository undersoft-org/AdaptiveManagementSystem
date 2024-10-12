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

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers.Open
{
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class ArchiveController
        : OpenCqrsController<
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
