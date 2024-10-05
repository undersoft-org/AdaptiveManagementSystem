// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Service.Application.GUI.Compound.Access;

using Undersoft.AMS.Service.Contracts.Accounts;

/// <summary>
/// The account validator.
/// </summary>
public class AccountSubscriptionValidator : ViewValidator<AccountSubscription>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public AccountSubscriptionValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {                     
            }
        );
    }
}
