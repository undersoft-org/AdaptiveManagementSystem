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
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Document.Financial;

    [Area("Data/Document/FinancialOrder")]
    public class FinancialOrderController
        : RemoteDataController<
            long,
            IDocumentFinancialStore,
            Order,
            FinancialOrder,
            ServiceManager
        >
    {
        public FinancialOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
