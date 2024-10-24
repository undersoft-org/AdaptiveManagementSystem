﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Market.Service.Server.Sales.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Market/Sales")]
    public class SaleProcessController
          : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            SaleProcess,
            ServiceManager
        >
    {
        public SaleProcessController(IServicer servicer)
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
