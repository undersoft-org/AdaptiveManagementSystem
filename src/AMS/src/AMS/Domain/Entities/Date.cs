// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Date : SDK.Service.Access.Identity.Date, IEntity
    {
        public virtual long? ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }

        public virtual long? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public virtual long? ActivityId { get; set; }
        public virtual Activity? Activity { get; set; }

        public virtual long? AmountId { get; set; }
        public virtual Amount? Amount { get; set; }
    }
}