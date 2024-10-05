// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Service.Contracts.Enums;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Data.Identifier;

namespace Undersoft.AMS.Service.Contracts
{
    public class Activity : DataObject, IContract
    {
        public virtual ActivityType Type { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual string? Description { get; set; }

        public virtual IdentifierSet<Activity>? Identifiers { get; set; }

        public virtual EntitySet<Activity>? RelatedFrom { get; set; }

        public virtual EntitySet<Activity>? RelatedTo { get; set; }

        public virtual EntitySet<Participant>? Participants { get; set; }

        public virtual EntitySet<Resource>? Resources { get; set; }

        public virtual EntitySet<Item>? Items { get; set; }

        public virtual EntitySet<Date>? Dates { get; set; }

        public virtual EntitySet<Amount>? Amounts { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }
    }
}