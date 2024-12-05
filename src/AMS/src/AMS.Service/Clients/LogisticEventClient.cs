using Undersoft.AMS.Market.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Service.Clients;

public class LogisticEventClient(Uri uri) : DataClient<ILogisticEventStore>(uri) { }
