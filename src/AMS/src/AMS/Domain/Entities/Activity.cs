// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Identifier;
using Undersoft.SDK.Service.Data.Remote;

namespace Undersoft.AMS.Domain.Entities
{
    public class Activity : Entity
    {
        public virtual ActivityType Type { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual IdentifierSet<Activity>? Identifiers { get; set; }

        public virtual Listing<Activity>? RelatedFrom { get; set; }

        public virtual Listing<Activity>? RelatedTo { get; set; }      

        public virtual Listing<Date>? Dates { get; set; }

        public virtual Listing<Amount>? Amounts { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public virtual Listing<Item>? Items { get; set; }
        
        public virtual Listing<Participant>? Participants { get; set; }

        public virtual Listing<RemoteLink<Activity, Participant>>? ActivitiesToParticipants { get; set; }
        
        public virtual Listing<Resource>? Resources { get; set; }

        public virtual Listing<RemoteLink<Activity, Resource>>? ActivitiesToResources { get; set; }
    }
}