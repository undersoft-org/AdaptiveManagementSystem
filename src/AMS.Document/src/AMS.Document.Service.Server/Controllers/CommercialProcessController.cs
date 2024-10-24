﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Document.Service.Server.Controllers
{
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Document.Commercial;
    using Undersoft.SDK.Service.Server.Controller;

    public class CommercialProcessController
        : RemoteDataController<
            long,
            IDocumentCommercialStore,
            CommercialProcess,
            CommercialProcess,
            ServiceManager
        >
    {
        public CommercialProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
