// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    using Undersoft.AMS.Market.Service.Clients.Abstractions;
    using Undersoft.AMS.Service.Contracts.Market.Sales;
    using Undersoft.SDK.Service.Server.Controller.Open;

    public class SaleProcessController
        : OpenDataRemoteController<long, IMarketSalesStore, SaleProcess, SaleProcess, ServiceManager>
    {
        public SaleProcessController(IServicer servicer)
            : base(servicer) { }
    }
}
