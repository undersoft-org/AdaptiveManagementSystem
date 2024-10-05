// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Address : SDK.Service.Access.Identity.Address, IEntity
    {
        public virtual long? ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }

        public virtual long? PlaceId { get; set; }
        public virtual Place? Place { get; set; }
    }
}