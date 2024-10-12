// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.AMS.Domain.Entities;
using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers.Open
{
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class MemberController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Participant,
            AMS.Service.Contracts.Participants.Member,
            ServiceManager
        >
    {
        public MemberController(IServicer servicer)
            : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Participant>()
                {
                    Filter = p => (p.Type & ParticipantType.Member) > 0,
                }
            ) { }
    }
}
