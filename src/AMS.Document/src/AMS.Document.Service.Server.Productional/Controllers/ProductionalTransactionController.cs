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

namespace Undersoft.AMS.Document.Service.Server.Productional.Controllers
{
    using Undersoft.AMS.Service.Contracts.Document.Productional;

    public class ProductionalTransactionController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            ProductionalTransaction,
            ServiceManager
        >
    {
        public ProductionalTransactionController(IServicer servicer)
             : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Transaction
                                | Domain.Entities.Enums.ActivityType.Productional
                            )
                        ) > 0
                }
            )
        { }
    }
}