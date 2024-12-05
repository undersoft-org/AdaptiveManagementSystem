// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Subjects.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Subjects/Procedure")]
    public class ProcedureController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Subject,
            Procedure,
            ServiceManager
        >
    {
        public ProcedureController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Subject>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.SubjectType.Procedure) > 0,
                }
            )
        { }
    }
}
