﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Document.Productional;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Document/ProductionalOffer")]
    public class ProductionalOfferController
        : RemoteDataController<
            long,
            IDocumentProductionalStore,
            Offer,
            ProductionalOffer,
            ServiceManager
        >
    {
        public ProductionalOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
