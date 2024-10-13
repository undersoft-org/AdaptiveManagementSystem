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

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers.Open
{
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class EnvironmentController
        : OpenCqrsController<
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
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Participant>()
                {
                    Filter = p =>
                      (p.Type & Domain.Entities.Enums.ParticipantType.Environment) > 0
                }
            ) { }
    }
}
