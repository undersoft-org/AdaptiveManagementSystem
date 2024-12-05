// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Project.Service.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Project.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Activities;
    using Undersoft.AMS.Service.Contracts.Project.Progress;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Project/ProgressOffer")]
    public class ProduceOfferController
        : RemoteDataController<
            long,
            IProjectProgressStore,
            Offer,
            ProgressOffer,
            ServiceManager
        >
    {
        public ProduceOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
