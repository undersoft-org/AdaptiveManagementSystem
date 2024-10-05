// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Location : SDK.Service.Access.Identity.Location, IEntity
    {   
        public virtual EntitySet<Place>? Places { get; set; }

        public virtual EntitySet<Endpoint>? Endpoints { get; set; }

        public virtual long? ActivityId { get; set; }
        public virtual Activity? Activity { get; set; }

        public virtual long? ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }

        public virtual long? SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }

        public virtual long? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public virtual long? ResourceId { get; set; }
        public virtual Resource? Resource { get; set; }
    }
}