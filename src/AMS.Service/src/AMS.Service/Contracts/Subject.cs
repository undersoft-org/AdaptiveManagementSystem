// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Data.Identifier;

namespace Undersoft.AMS.Service.Contracts
{
    public class Subject : DataObject, IContract
    {
        public virtual SubjectType Type { get; set; }

        public virtual IdentifierSet<Subject>? Identifiers { get; set; }

        public virtual EntitySet<Subject>? RelatedFrom { get; set; }

        public virtual EntitySet<Subject>? RelatedTo { get; set; }

        public virtual EntitySet<Resource>? Resources { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual bool IsVariant { get; set; }

        public virtual EntitySet<Amount>? Amounts { get; set; }
    }
}