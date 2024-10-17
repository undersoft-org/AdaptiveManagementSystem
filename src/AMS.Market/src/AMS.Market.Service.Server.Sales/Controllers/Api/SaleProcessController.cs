﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Market.Service.Server.Sales.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/market/sales/SaleProcess")]
    public class SaleProcessController
          : ApiCqrsController<
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
                EventPublishMode.PropagateCommand,
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
