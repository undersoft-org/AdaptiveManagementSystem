// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Document.Service.Server.Logistical.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Logistical;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/document/logistical/LogisticalOffer")]
    public class LogisticalOfferController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            LogisticalOffer,
            ServiceManager
        >
    {
        public LogisticalOfferController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Offer
                                | Domain.Entities.Enums.ActivityType.Logistical
                            )
                        ) > 0,
                }
            )
        { }
    }
}
