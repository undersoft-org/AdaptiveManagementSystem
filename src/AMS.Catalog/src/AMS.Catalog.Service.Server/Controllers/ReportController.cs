﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Resources;

    [Area("Data/Catalog")]
    public class ReportController
        : RemoteDataController<
            long,
            ICatalogResourcesStore,
            Report,
            Report,
            ServiceManager
        >
    {
        public ReportController(IServicer servicer) : base(servicer) { }
    }
}
