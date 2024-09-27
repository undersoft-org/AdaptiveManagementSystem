﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Vaccination;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class AppointmentController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Vaccination.Appointment,
            Appointment,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public AppointmentController(IServicer servicer) : base(servicer) { }
    }
}