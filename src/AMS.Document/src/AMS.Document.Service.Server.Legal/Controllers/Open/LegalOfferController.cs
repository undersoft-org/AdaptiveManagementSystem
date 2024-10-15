// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Document.Service.Server.Legal.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Legal;
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class LegalOfferController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            LegalOffer,
            ServiceManager
        >
    {
        public LegalOfferController(IServicer servicer)
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
                                | Domain.Entities.Enums.ActivityType.Legal
                            )
                        ) > 0,
                }
            )
        { }
    }
}
