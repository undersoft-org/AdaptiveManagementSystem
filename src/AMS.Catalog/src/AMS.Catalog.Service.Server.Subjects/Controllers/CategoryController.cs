﻿// ********************************************************
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

    [Area("Data/Catalog/Subjects/Category")]
    public class CategoryController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Subject,
            Category,
            ServiceManager
        >
    {
        public CategoryController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Subject>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.SubjectType.Category) > 0,
                }
            )
        { }
    }
}
