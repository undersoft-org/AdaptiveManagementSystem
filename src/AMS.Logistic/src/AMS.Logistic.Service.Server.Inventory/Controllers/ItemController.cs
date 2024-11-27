// ********************************************************
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
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Logistic/Inventory/Item")]
    public class ItemController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Item,
            Item,
            ServiceManager
        >
    {
        public ItemController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Item>()
                {
                    Filter = p => (p.Type & Domain.Entities.Enums.ItemType.Inventory) > 0,
                }
            )
        { }
    }
}
