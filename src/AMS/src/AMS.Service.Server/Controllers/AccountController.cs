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
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.SDK.Service.Server.Controller.Open;

namespace Undersoft.AMS.Service.Server.Controllers.Open
{
    public class AccountController
        : OpenDataController<
            long,
            IAccountStore,
            Account,
            Contracts.Account,
            AccountService<Contracts.Account>
        >
    {
        public AccountController(IServicer servicer) : base(servicer, EventPublishMode.None) { }
    }
}


namespace Undersoft.AMS.Service.Server.Controllers.Api
{
    [Route($"api/auth/Account")]
    public class AccountsController
        : ApiDataController<
            long,
            IAccountStore,
            Account,
            Contracts.Account,
            AccountService<Contracts.Account>
        >
    {
        public AccountsController(IServicer servicer) : base(servicer, EventPublishMode.None) { }
    }
}