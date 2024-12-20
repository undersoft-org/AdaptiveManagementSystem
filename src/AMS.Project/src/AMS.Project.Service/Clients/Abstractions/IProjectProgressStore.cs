﻿// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Project.Service
// *************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Project.Service.Clients.Abstractions
{
    public interface IProjectProgressStore : IDataStore, IEntryStore, IReportStore
    {
    }
}