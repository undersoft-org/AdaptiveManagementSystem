// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.AMS.Catalog.Service.Application.GUI.Compound.Presenting.Validators;

public class EventValidator : ViewValidator<AMS.Service.Contracts.Event>
{
    public EventValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationKind.Any,
            () =>
            {
                ValidateRequired(p => p.Model.EventType);
                ValidateRequired(p => p.Model.EntityId);
                ValidateRequired(p => p.Model.EntityTypeName);
            }
        );
    }
}
