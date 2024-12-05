// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Project.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Project.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Project.Requests;

    [Area("Data/Project/RequestOrder")]
    public class PurchaseOrderController
        : RemoteDataController<
            long,
            IProjectRequestsStore,
            Order,
            RequestOrder,
            ServiceManager
        >
    {
        public PurchaseOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
