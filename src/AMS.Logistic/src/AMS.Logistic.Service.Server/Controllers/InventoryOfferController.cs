// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Undersoft.AMS.Service.Contracts.Logistic.Inventory;
    using Undersoft.SDK.Service.Server.Controller;

    public class InventoryOfferController
        : RemoteDataController<long, IEntryStore, InventoryOffer, InventoryOffer, ServiceManager>
    {
        public InventoryOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
