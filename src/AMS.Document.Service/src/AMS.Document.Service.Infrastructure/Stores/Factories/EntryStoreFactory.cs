﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service.Infrastructure
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;

namespace Undersoft.AMS.Document.Service.Infrastructure.Stores.Factories
{
    /// <summary>
    /// The entry store factory.
    /// </summary>
    public class EntryStoreFactory : DbStoreFactory<EntryStore, ServerSourceProviderConfiguration> { }
}
