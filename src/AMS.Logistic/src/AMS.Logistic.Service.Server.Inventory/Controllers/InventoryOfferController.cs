﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Logistic.Service.Server.Inventory.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Logistic/Inventory")]
    public class InventoryOfferController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            InventoryOffer,
            ServiceManager
        >
    {
        public InventoryOfferController(IServicer servicer)
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
                                | Domain.Entities.Enums.ActivityType.Inventory
                            )
                        ) > 0,
                }
            )
        { }
    }
}
