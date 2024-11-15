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
    [Validator("AccountProfessionalValidator", typeof(AccountProfessional))]
    public class AccountProfessional : SDK.Service.Access.Identity.Professional, IContract
    {
    }
}