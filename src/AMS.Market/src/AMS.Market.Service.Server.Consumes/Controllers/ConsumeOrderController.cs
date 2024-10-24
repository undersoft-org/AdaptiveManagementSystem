﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Market.Service.Server.Consumes.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Consumes;

    [Area("Data/Market/Consumes")]
    public class ConsumeOrderController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            ConsumeOrder,
            ServiceManager
        >
    {
        public ConsumeOrderController(IServicer servicer)
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
                                | Domain.Entities.Enums.ActivityType.Consume
                            )
                        ) > 0,
                }
            )
        { }
    }
}
