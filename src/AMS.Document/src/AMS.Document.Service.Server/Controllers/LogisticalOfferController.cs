// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Document.Logistical;
    using Undersoft.SDK.Service.Server.Controller;

    public class LogisticalOfferController
        : RemoteDataController<
            long,
            IDocumentLogisticalStore,

           LogisticalOffer,
            LogisticalOffer,
            ServiceManager
        >
    {
        public LogisticalOfferController(IServicer servicer)
            : base(
                servicer)
        { }
    }
}
