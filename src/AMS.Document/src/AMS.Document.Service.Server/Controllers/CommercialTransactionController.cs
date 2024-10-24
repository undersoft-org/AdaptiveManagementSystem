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
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Document.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Document.Commercial;

    [Area("Data/Document")]
    public class CommercialTransactionController
        : RemoteDataController<
            long,
            IDocumentCommercialStore,
            CommercialTransaction,
            CommercialTransaction,
            ServiceManager
        >
    {
        public CommercialTransactionController(IServicer servicer)
            : base(servicer) { }
    }
}
