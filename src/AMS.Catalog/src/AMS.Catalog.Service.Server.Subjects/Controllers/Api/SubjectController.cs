// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Catalog.Service.Server.Subjects.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts;

    [Route($"api/data/catalog/subjects/Subject")]
    public class SubjectController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Subject,
            Subject,
            ServiceManager
        >
    {
        public SubjectController(IServicer servicer)
            : base(servicer) { }        
    }
}