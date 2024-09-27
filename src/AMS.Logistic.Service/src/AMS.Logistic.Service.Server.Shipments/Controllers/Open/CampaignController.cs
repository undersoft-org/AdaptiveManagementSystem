﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Logistic.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Logistic.Service.Server.Catalogs.Controllers.Open
{
    using Undersoft.AMS.Logistic.Service.Contracts.Catalogs;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class CampaignController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Catalogs.Campaign,
            Campaign,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public CampaignController(IServicer servicer) : base(servicer) { }
    }
}