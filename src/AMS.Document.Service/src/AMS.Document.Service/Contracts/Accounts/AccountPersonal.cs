﻿// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service
// *************************************************

using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Document.Service.Contracts.Accounts
{
    public class AccountPersonal : SDK.Service.Access.Identity.Personal, IContract
    {
        public virtual long? AccountId { get; set; }
    }
}