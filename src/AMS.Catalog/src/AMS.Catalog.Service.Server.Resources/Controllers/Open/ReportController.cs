// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.AMS.Service.Contracts.Resources;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Data.Query;

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers.Open
{
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class ReportController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Resource,
            Report,
            ServiceManager
        >
    {
        public ReportController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Resource>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.ResourceType.Report) > 0,
                }
            ) { }
    }
}
