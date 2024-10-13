// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Resources.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class ImageController
        : OpenCqrsController<
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
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Resource>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.ResourceType.Image) > 0,
                }
            ) { }
    }
}
