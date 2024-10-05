// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Logistic.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Logistic.Service.Server.Inventory.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Server.Controller.Api;
    using Undersoft.AMS.Logistic.Service.Contracts.Inventory;

    /// <summary>
    /// The contact controller.
    /// </summary>
    [Route($"{StoreRoutes.ApiDataRoute}/Supplier")]
    public class SuppliersController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Inventory.Supplier,
            Supplier,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public SuppliersController(IServicer servicer) : base(servicer) { }
    }
}