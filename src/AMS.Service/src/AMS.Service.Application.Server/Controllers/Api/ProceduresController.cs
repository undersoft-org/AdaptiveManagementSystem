// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Application.Server.Controllers.Api;

using Microsoft.AspNetCore.Mvc;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts.Vaccination;

/// <summary>
/// The contact controller.
/// </summary>
[Route($"{StoreRoutes.ApiDataRoute}/Procedure")]
public class ProceduresController
    : ApiDataRemoteController<long, IMarketStore, Procedure, Procedure, ServiceManager>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public ProceduresController(IServicer servicer) : base(servicer) { }
}
