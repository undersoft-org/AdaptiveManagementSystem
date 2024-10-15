// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Query;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Commercial.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Commercial;

    public class CommercialTransactionController
        : OpenCqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Activity,
            CommercialTransaction,
            ServiceManager
        >
    {
        public CommercialTransactionController(IServicer servicer)
             : base(
                servicer,
                EventPublishMode.PropagateCommand,
                new QueryParameters<Domain.Entities.Activity>()
                {
                    Filter = p =>
                        (
                            p.Type
                            & (
                                Domain.Entities.Enums.ActivityType.Transaction
                                | Domain.Entities.Enums.ActivityType.Commercial
                            )
                        ) > 0
                }
            )
        { }
    }
}