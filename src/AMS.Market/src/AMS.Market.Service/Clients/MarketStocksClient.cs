using Undersoft.AMS.Market.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Market.Service.Clients;

public class MarketStocksClient(Uri uri) : DataClient<IMarketStocksStore>(uri) { }
