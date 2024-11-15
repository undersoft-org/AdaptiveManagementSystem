// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service
// *************************************************

using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Operation;

namespace Undersoft.AMS.Service.Contracts.Accounts
{
    [Validator("AccountPersonalValidator", typeof(AccountPersonal))]
    public class AccountPersonal : SDK.Service.Access.Identity.Personal, IContract
    {
        public virtual long? AccountId { get; set; }
    }
}