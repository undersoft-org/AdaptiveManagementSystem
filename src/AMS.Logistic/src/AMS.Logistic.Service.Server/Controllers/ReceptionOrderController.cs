// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Receptions;

    public class ReceptionOrderController
        : RemoteDataController<
            long,
            ILogisticReceptionsStore,
            ReceptionOrder,
            ReceptionOrder,
            ServiceManager
        >
    {
        public ReceptionOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
