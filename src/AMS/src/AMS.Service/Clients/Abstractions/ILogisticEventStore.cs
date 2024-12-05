// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************


using Undersoft.AMS.Logistic.Service.Clients.Abstractions;

namespace Undersoft.AMS.Service.Clients.Abstractions
{
    public interface ILogisticEventStore : ILogisticInventoryEventStore, ILogisticReceptionsEventStore, ILogisticShipmentsEventStore
    {
    }
}