// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Identifier;
using Undersoft.SDK.Service.Data.Remote.Repository;
using Undersoft.SDK.Service.Data.Remote;

namespace Undersoft.AMS.Domain.Entities
{
    public class Subject : Entity
    {
        public virtual SubjectType Type { get; set; }

        public virtual IdentifierSet<Subject>? Identifiers { get; set; }

        public virtual Listing<Subject>? RelatedFrom { get; set; }

        public virtual Listing<Subject>? RelatedTo { get; set; }
        
        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual bool IsVariant { get; set; } 

        public virtual Listing<Amount>? Amounts { get; set; }

        public virtual long? LocationId { get; set; }

        public virtual Location? Location { get; set; }
        
        public virtual RemoteSet<Item>? Items { get; set; }
        
        public virtual Listing<Resource>? Resources { get; set; }

        public virtual Listing<RemoteLink<Subject, Resource>>? SubjectsToResources { get; set; }
    }
}