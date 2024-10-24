// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Document.Commercial;

    public class CommercialOrderController
        : RemoteDataController<
            long,
            IDocumentCommercialStore,
            CommercialOrder,
            CommercialOrder,
            ServiceManager
        >
    {
        public CommercialOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
