// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service;

namespace Undersoft.AMS.Service.Application.Server.Controllers.Open;

using Undersoft.SDK.Service.Server.Controller.Open;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts.Inventory;

public class TrafficController
    : OpenDataRemoteController<
        long,
        IInventoryStore,
        Traffic,
        Traffic,
        ServiceManager
    >
{
    public TrafficController(IServicer servicer) : base(servicer) { }
}
