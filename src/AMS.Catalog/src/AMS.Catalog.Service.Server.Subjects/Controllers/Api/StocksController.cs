// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Catalog.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Inventory.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Server.Controller.Api;
    using Undersoft.AMS.Catalog.Service.Contracts.Inventory;

    /// <summary>
    /// The contact controller.
    /// </summary>
    [Route($"{StoreRoutes.ApiDataRoute}/Stock")]
    public class StocksController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Inventory.Stock,
            Stock,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public StocksController(IServicer servicer) : base(servicer) { }
    }
}