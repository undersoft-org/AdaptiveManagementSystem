// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Application.Server.Controllers.Open;

using Undersoft.SDK.Service;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts.Catalogs;

public class CampaignController
    : OpenDataRemoteController<long, ICatalogsStore, Campaign, Campaign, ServiceManager>
{
    public CampaignController(IServicer servicer) : base(servicer) { }
}
