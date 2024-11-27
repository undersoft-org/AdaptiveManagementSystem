// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Shipments.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Activities;

    [Area("Data/Logistic/Shipments/Transaction")]
    public class TransactionController(IServicer servicer)
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            Transaction,
            ServiceManager
        >(
            servicer,
            PublishMode.Propagate,
            new QueryParameters<Domain.Entities.Activity>()
            {
                Filter = p =>
                    (
                        p.Type
                        & (
                            Domain.Entities.Enums.ActivityType.Transaction
                            | Domain.Entities.Enums.ActivityType.Shipment
                        )
                    ) > 0,
            }
        ) { }
}
