﻿// ********************************************************
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
    using Undersoft.AMS.Service.Contracts.Document.Financial;

    public class FinancialOrderController
        : RemoteDataController<
            long,
            IDocumentFinancialStore,
            FinancialOrder,
            FinancialOrder,
            ServiceManager
        >
    {
        public FinancialOrderController(IServicer servicer)
            : base(servicer) { }
    }
}
