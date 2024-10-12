// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Access.Identity;
using Undersoft.SDK.Service.Data.Identifier;

namespace Undersoft.AMS.Domain.Entities
{
    public class Participant : Entity
    {
        public virtual ParticipantType Type { get; set; }

        public virtual IdentifierSet<Participant>? Identifiers { get; set; }

        public virtual EntitySet<Participant>? RelatedFrom { get; set; }

        public virtual EntitySet<Participant>? RelatedTo { get; set; }      

        public virtual EntitySet<Resource>? Resources { get; set; }

        public virtual EntitySet<Activity>? Activities { get; set; }

        public virtual EntitySet<Item>? Items { get; set; }

        public virtual string? Nickname { get; set; }

        public virtual string? FirstName { get; set; }

        public virtual string? LastName { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual EntitySet<Email>? Emails { get; set; }

        public virtual EntitySet<Phone>? Phones { get; set; }

        public virtual EntitySet<Address>? Addresses { get; set; }

        public virtual EntitySet<Date>? Dates { get; set; }

        public virtual EntitySet<Amount>? Amounts { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public virtual string? SocialMedia { get; set; }

        public virtual string? Websites { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
