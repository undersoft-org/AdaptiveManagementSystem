// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Document.Service.Server.Commercial.Controllers.Open
{
    using Undersoft.AMS.Service.Contracts.Document.Commercial;
    using Undersoft.SDK.Service.Data.Store;

    public class CommercialEventController
        : OpenEventController<
            long,
            IEventStore,
            Event,
            CommercialEvent
        >
    {
        public CommercialEventController(IServicer servicer) : base(servicer) { }
    }
}
