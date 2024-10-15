// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Financial.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Financial;
    using Undersoft.SDK.Service.Data.Store;

    public class FinancialEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            FinancialEvent
        >
    {
        public FinancialEventController(IServicer servicer) : base(servicer) { }
    }
}
