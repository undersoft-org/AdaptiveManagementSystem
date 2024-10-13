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

namespace Undersoft.AMS.Catalog.Service.Server.Subjects.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/catalog/subjects/Element")]
    public class ElementController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Subject,
            Element,
            ServiceManager
        >
    {
        public ElementController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Subject>()
                {
                    Filter = p => (p.Type & SubjectType.Element) > 0,
                }
            ) { }
    }
}
