// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Contracts.Vaccination;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class ProcedureController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Vaccination.Procedure,
            Procedure,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public ProcedureController(IServicer servicer) : base(servicer) { }
    }
}