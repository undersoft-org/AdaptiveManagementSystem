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
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Application.Server.Controllers.Api
{
    [Route($"{StoreRoutes.ApiAuthRoute}/Account")]
    public class AccountsController
        : ApiDataRemoteController<
            long,
            IAccountStore,
            Contracts.Account,
            Contracts.Account,
            AccountService<Contracts.Account>
        >
    {
        public AccountsController(IServicer servicer) : base(servicer) { }
    }
}

namespace Undersoft.AMS.Service.Application.Server.Controllers.Open
{
    public class AccountController
        : OpenDataRemoteController<
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
