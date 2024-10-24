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

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers
{
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;
    using Undersoft.SDK.Service.Server.Controller;

    public class MemberController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Participant,
            Member,
            ServiceManager
        >
    {
        public MemberController(IServicer servicer)
            : base(
                servicer,
                PublishMode.Propagate,
                new QueryParameters<Participant>()
                {
                    Filter = p => (p.Type & ParticipantType.Member) > 0,
                }
            )
        { }
    }
}
