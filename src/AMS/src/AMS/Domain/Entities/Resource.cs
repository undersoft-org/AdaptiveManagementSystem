// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Remote.Repository;
using Undersoft.SDK.Service.Data.Remote;

namespace Undersoft.AMS.Domain.Entities
{
    public class Resource : Entity
    {
        public virtual ResourceType Type { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? Description { get; set; }

        public virtual string? Member { get; set; }

        public virtual byte[]? MemberData { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }
        
        public virtual Listing<Activity>? Activities { get; set; }

        public virtual Listing<RemoteLink<Activity, Resource>>? ActivitiesToResources { get; set; }
        
        public virtual Listing<Participant>? Participants { get; set; }

        public virtual Listing<RemoteLink<Participant, Resource>>? ParticipantsToResources { get; set; }
        
        public virtual Listing<Subject>? Subjects { get; set; }

        public virtual Listing<RemoteLink<Subject, Resource>>? SubjectsToResources { get; set; }


    }
}