// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Catalog.Service.Server.Participants.Validators
{
    using Undersoft.AMS.Service.Contracts.Resources;

    public class ImagesValidator : CommandSetValidator<Image>
    {
        public ImagesValidator(IServicer servicer) : base(servicer)
        {
            ValidationScope(
                OperationType.Any,
                () =>
                {
                    ValidateRequired(p => p.Contract.Name);
                    ValidateRequired(p => p.Contract.Member);
                    ValidateRequired(p => p.Contract.MemberData);
                }
            );

        }
    }
}