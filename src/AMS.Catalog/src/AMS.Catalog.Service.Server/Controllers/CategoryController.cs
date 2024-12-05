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

    [Area("Data/Catalog/Category")]
    public class CategoryController
        : RemoteDataController<
            long,
            ICatalogSubjectsStore,
            Category,
            Category,
            ServiceManager
        >
    {
        public CategoryController(IServicer servicer) : base(servicer) { }
    }
}
