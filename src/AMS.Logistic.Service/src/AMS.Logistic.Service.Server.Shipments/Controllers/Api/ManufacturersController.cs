﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Logistic.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Logistic.Service.Server.Catalogs.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Server.Controller.Api;
    using Undersoft.AMS.Logistic.Service.Contracts.Catalogs;

    /// <summary>
    /// The contact controller.
    /// </summary>
    [Route($"{StoreRoutes.ApiDataRoute}/Manufacturer")]
    public class ManufacturersController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Catalogs.Manufacturer,
            Manufacturer,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public ManufacturersController(IServicer servicer)
            : base(servicer) { }
    }
}