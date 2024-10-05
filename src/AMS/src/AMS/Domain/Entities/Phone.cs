// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Phone : SDK.Service.Access.Identity.Phone, IEntity
    {
        public virtual long? ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }
    }
}