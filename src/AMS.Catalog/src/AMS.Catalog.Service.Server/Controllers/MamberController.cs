﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;

    [Area("Data/Catalog/Member")]
    public class MamberController
        : RemoteDataController<
            long,
            ICatalogParticipantsStore,
            Member,
            Member,
            ServiceManager
        >
    {
        public MamberController(IServicer servicer) : base(servicer) { }
    }
}
