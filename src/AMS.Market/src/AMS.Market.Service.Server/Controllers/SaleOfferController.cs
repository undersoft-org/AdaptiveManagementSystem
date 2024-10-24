// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Microsoft.AspNetCore.Mvc;
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller;

    [Area("Data/Market")]
    public class SaleOfferController
        : RemoteDataController<long, IMarketSalesStore, SaleOffer, SaleOffer, ServiceManager>
    {
        public SaleOfferController(IServicer servicer)
            : base(servicer) { }
    }
}
