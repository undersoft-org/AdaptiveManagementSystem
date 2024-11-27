using Microsoft.OData.Edm;
using Undersoft.AMS.Logistic.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************


namespace Undersoft.AMS.Logistic.Service.Clients;

public class LogisticShipmentsClient(Uri serviceUri)
    : DataClient<ILogisticShipmentsStore>(serviceUri) { }
