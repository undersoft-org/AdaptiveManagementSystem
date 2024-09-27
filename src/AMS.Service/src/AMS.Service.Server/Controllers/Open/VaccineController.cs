﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Server.Controllers.Open;

using Undersoft.AMS.Service.Contracts.Catalogs;

/// <summary>
/// The contact controller.
/// </summary>
public class VaccineController
    : OpenCqrsController<
        long,
        IEntryStore,
        IReportStore,
        Domain.Entities.Catalogs.Vaccine,
        Vaccine,
        ServiceManager
    >
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public VaccineController(IServicer servicer) : base(servicer) { }
}
