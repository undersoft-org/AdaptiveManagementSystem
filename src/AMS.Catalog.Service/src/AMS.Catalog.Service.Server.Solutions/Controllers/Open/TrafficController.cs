﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Catalog.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Catalog.Service.Server.Inventory.Controllers.Open
{
    using Undersoft.AMS.Catalog.Service.Contracts.Inventory;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class TrafficController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Inventory.Traffic,
            Traffic,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public TrafficController(IServicer servicer) : base(servicer) { }
    }
}