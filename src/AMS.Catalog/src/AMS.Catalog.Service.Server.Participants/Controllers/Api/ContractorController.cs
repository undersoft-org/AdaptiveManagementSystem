// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Data.Query;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;
    using Undersoft.SDK.Service.Server.Controller.Api;

    [Route($"api/data/catalog/participants/Contractor")]
    public class ContractorController
        : ApiCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Participant,
            Contractor,
            ServiceManager
        >
    {
        public ContractorController(IServicer servicer)
             : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Participant>()
                {
                    Filter = p =>
                        (p.Type & Domain.Entities.Enums.ParticipantType.Contractor) > 0,
                }
            )
        { }
    }
}