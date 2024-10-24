using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Accounts;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.AMS.Service.Application.Server.Controllers
{
    [Area("Auth")]
    public class AccountController
        : RemoteDataController<
            long,
            IAccountStore,
            Contracts.Account,
            Contracts.Account,
            AccountService<Contracts.Account>
        >
    {
        public AccountController(IServicer servicer) : base(servicer) { }
    }
}
