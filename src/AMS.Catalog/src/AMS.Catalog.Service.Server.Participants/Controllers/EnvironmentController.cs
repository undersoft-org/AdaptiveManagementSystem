// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Environment = Undersoft.AMS.Service.Contracts.Catalog.Participants.Environment;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Catalog/Participants")]
    public class EnvironmentController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Participant,
            Environment,
            ServiceManager
        >
    {
        public EnvironmentController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Domain.Entities.Participant>()
                {
                    Filter = p =>
                      (p.Type & Domain.Entities.Enums.ParticipantType.Environment) > 0
                }
            )
        { }
    }
}
