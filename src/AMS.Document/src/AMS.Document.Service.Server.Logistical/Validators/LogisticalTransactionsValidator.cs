// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service.Operation.Command.Validator;

namespace Undersoft.AMS.Catalog.Service.Server.Subjects.Validators
{
    using Undersoft.AMS.Service.Contracts.Document.Logistical;

    public class LogisticalTransactionsValidator : CommandSetValidator<LogisticalTransaction>
    {
        public LogisticalTransactionsValidator(IServicer servicer) : base(servicer)
        {
            ValidationScope(
                OperationKind.Any,
                () =>
                {
                    ValidateRequired(p => p.Contract.Name);
                    ValidateRequired(p => p.Contract.FullName);
                }
            );

        }
    }
}