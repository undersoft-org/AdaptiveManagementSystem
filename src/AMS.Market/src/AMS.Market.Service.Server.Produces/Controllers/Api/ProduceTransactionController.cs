﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Produces.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Produces;

    [Route($"api/data/market/produces/ProduceTransaction")]
    public class ProduceTransactionController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            ProduceTransaction,
            ServiceManager
        >
    {
        public ProduceTransactionController(IServicer servicer)
             : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Transaction
                                | Domain.Entities.Enums.ActivityType.Produce
                            )
                        ) > 0
                }
            )
        { }
    }
}
