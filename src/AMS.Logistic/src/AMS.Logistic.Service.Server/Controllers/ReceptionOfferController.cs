// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Logistic.Service.Server.Controllers
{
    using Undersoft.AMS.Logistic.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Logistic.Receptions;
    using Undersoft.SDK.Service.Server.Controller;

    public class ReceptionOfferController
        : RemoteDataController<
            long,
            ILogisticReceptionsStore,
            ReceptionOffer,
            ReceptionOffer,
            ServiceManager
        >
    {
        public ReceptionOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
