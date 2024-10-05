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
    public class Item : Entity
    {
        public virtual ItemType Type { get; set; }

        public virtual long? ActivityId { get; set; }
        public virtual Activity? Activity { get; set; }

        public virtual long? ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }

        public virtual long? SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual EntitySet<Amount>? Amounts { get; set; }

        public virtual EntitySet<Date>? Dates { get; set; }
        
        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }
    }
}