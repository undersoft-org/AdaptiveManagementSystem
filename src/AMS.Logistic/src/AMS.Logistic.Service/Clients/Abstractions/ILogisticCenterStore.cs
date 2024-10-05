// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Logistic.Service.Clients.Abstractions
{

    public interface ILogisticCenterStore : ILogisticInventoryStore, ILogisticDeliveriesStore, ILogisticShipmentsStore
    {
    }
}
