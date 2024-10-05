// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Service.Contracts
{
    public class Location : SDK.Service.Access.Identity.Location, IEntity
    {
        public virtual EntitySet<Place>? Places { get; set; }

        public virtual EntitySet<Endpoint>? Endpoints { get; set; }

        public virtual long? ActivityId { get; set; }

        public virtual long? ParticipantId { get; set; }

        public virtual long? SubjectId { get; set; }

        public virtual long? ItemId { get; set; }

        public virtual long? ResourceId { get; set; }
    }
}