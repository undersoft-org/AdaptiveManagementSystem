// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Controllers
{
    using Undersoft.AMS.Service.Contracts.Catalog.Participants;
    using Undersoft.SDK.Service.Server.Controller;

    public class ParticipantController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Participant,
            Contractor,
            ServiceManager
        >
    {
        public ParticipantController(IServicer servicer)
            : base(servicer) { }
    }
}
