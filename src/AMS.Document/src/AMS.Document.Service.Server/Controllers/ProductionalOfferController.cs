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
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Server.Controller;

    public class ProductionalOfferController
        : RemoteDataController<
            long,
            IDocumentProductionalStore,
            ProductionalOffer,
            ProductionalOffer,
            ServiceManager
        >
    {
        public ProductionalOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
