﻿using Undersoft.AMS.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Service.Clients;

public class CatalogEventClient(Uri uri) : DataClient<ICatalogEventStore>(uri) { }