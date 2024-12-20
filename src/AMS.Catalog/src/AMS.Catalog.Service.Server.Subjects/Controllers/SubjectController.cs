﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Subjects.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts;

    [Area("Data/Catalog/Subjects/Subject")]
    public class SubjectController
        : CqrsController<
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
