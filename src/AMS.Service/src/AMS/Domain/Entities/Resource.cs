// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;

namespace Undersoft.AMS.Domain.Entities
{
    public class Resource : Entity
    {
        public virtual ResourceType Type { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? Description { get; set; }

        public virtual string? Member { get; set; }

        public virtual byte[]? MemberData { get; set; }

        public virtual EntitySet<Activity>? Activities { get; set; }

        public virtual EntitySet<Participant>? Participants { get; set; }

        public virtual EntitySet<Subject>? Subjects { get; set; }
    }
}