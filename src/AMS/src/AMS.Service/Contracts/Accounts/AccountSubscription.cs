// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service
// *************************************************

using Undersoft.SDK.Service.Access.Licensing;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Operation;

namespace Undersoft.AMS.Service.Contracts.Accounts
{
    [Validator("AccountSubscriptionValidator", typeof(AccountSubscription))]
    public class AccountSubscription : Subscription, IContract
    {
    }
}