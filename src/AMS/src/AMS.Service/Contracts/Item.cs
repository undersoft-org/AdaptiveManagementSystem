// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities;
using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.AMS.Service.Contracts.Base;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Data.Remote.Repository;

namespace Undersoft.AMS.Service.Contracts
{
    public class Item : DataObject, IContract
    {
        public virtual ItemType Type { get; set; }

        public virtual long? ActivityId { get; set; }  

        [Remote]
        public virtual ParticipantBase? Participant { get; set; }
        public virtual long? ParticipantId { get; set; }

        [Remote] 
        public virtual SubjectBase? Subject { get; set; }
        public virtual long? SubjectId { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual Listing<Amount>? Amounts { get; set; }

        public virtual Listing<Date>? Dates { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }
    }
}