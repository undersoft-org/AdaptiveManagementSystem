using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Accounts;
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api
{
    [Route($"{StoreRoutes.ApiAuthRoute}/Account")]
    public class AccountsController
        : ApiDataController<
            long,
            IAccountStore,
            Account,
            AMS.Service.Contracts.Account,
            AccountService<AMS.Service.Contracts.Account>
        >
    {
        public AccountsController(IServicer servicer) : base(servicer) { }
    }
}

namespace Undersoft.AMS.Market.Service.Server.Controllers.Open
{
    public class AccountController
        : OpenDataController<
            long,
            IAccountStore,
            Account,
            AMS.Service.Contracts.Account,
            AccountService<AMS.Service.Contracts.Account>
        >
    {
        public AccountController(IServicer servicer) : base(servicer) { }
    }
}