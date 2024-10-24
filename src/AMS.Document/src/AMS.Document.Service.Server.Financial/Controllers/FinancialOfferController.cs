﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Document.Service.Server.Financial.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Document.Financial;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Document/Financial")]
    public class FinancialOfferController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            FinancialOffer,
            ServiceManager
        >
    {
        public FinancialOfferController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Offer
                                | Domain.Entities.Enums.ActivityType.Financial
                            )
                        ) > 0,
                }
            )
        { }
    }
}
