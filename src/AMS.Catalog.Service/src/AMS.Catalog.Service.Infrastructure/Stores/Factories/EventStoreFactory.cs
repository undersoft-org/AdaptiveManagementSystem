﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog.Service.Infrastructure
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;

namespace Undersoft.AMS.Catalog.Service.Infrastructure.Stores.Factories
{
    /// <summary>
    /// The event store factory.
    /// </summary>
    public class EventStoreFactory : DbStoreFactory<EventStore, ServerSourceProviderConfiguration> { }
}
