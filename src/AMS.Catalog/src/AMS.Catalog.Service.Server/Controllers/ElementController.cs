// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Subjects")]
    public class ElementController
        : RemoteDataController<
            long,
            ICatalogSubjectsStore,
            Element,
            Element,
            ServiceManager
        >
    {
        public ElementController(IServicer servicer) : base(servicer) { }
    }
}
