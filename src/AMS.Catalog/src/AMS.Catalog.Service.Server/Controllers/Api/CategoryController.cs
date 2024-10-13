using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers.Api
{
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Subjects;

    [Route($"api/data/catalog/Category")]
    public class CategoryController
        : ApiDataRemoteController<
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
