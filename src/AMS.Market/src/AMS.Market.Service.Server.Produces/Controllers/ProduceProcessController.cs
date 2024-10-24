// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Market.Service.Server.Produces.Controllers
{
    using Undersoft.AMS.Service.Contracts.Market.Produces;
    using Undersoft.SDK.Service.Server.Controller;

    public class ProduceProcessController
          : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            ProduceProcess,
            ServiceManager
        >
    {
        public ProduceProcessController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Order
                                | Domain.Entities.Enums.ActivityType.Process
                            )
                        ) > 0,
                }
            )
        { }
    }
}
