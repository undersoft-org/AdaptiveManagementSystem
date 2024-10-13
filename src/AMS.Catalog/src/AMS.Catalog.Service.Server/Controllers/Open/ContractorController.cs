// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Catalog.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Catalog.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;


    public class ContractorController
        : OpenDataRemoteController<
            long,
            ICatalogParticipantsStore,
            Contractor,
            Contractor,
            ServiceManager
        >
    {
        public ContractorController(IServicer servicer) : base(servicer) { }
    }
}
