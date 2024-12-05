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

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Resources/Archive")]
    public class FileController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Resource,
            File,
            ServiceManager
        >
    {
        public FileController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Resource>()
                {
                    Filter = p => (p.Type & ResourceType.File) > 0,
                }
            )
        { }
    }
}
