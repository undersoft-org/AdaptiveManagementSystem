// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

namespace Undersoft.AMS.Service.Application.Server.Controllers.Open;

using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller.Open;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts.Vaccination;

public class PostSymptomController
    : OpenDataRemoteController<long, IVaccinationStore, PostSymptom, PostSymptom, ServiceManager>
{
    public PostSymptomController(IServicer servicer) : base(servicer) { }
}
