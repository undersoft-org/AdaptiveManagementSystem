// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Microsoft.AspNetCore.Mvc;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Accounts;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Service.Server.Controllers
{
    [Area("Auth")]
    public class AccountController
        : DataController<
            long,
            IAccountStore,
            Account,
            Contracts.Account,
            AccountService<Contracts.Account>
        >
    {
        public AccountController(IServicer servicer) : base(servicer, PublishMode.None) { }
    }
}