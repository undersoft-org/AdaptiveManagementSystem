﻿// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog.Service
// *************************************************

using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Catalog.Service.Contracts.Accounts
{
    public class AccountAddress : SDK.Service.Access.Identity.Address, IContract
    {
        public virtual long? AccountId { get; set; }
    }
}