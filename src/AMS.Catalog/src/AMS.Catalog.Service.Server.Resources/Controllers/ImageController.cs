// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Resources/Image")]
    public class ImageController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Resource,
            Image,
            ServiceManager
        >
    {
        public ImageController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Resource>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.ResourceType.Image) > 0,
                }
            )
        { }
    }
}
