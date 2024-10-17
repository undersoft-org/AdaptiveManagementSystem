﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Logistical.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Logistical;

    public class LogisticalOrderController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            LogisticalOrder,
            ServiceManager
        >
    {
        public LogisticalOrderController(IServicer servicer)
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
                                | Domain.Entities.Enums.ActivityType.Logistical
                            )
                        ) > 0,
                }
            )
        { }
    }
}