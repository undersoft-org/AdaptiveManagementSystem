using Microsoft.EntityFrameworkCore;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Infrastructure
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Accounts;

namespace Undersoft.AMS.Service.Infrastructure.Stores
{
    public class AccountStore : AccountStore<IAccountStore, AccountStore>
    {
        public AccountStore(DbContextOptions<AccountStore> options) : base(options) { }
    }
}