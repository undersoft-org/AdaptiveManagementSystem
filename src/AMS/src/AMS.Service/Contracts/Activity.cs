// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Service.Contracts.Base;
using Undersoft.SDK.Service.Data.Identifier;
using Undersoft.SDK.Service.Data.Remote.Repository;

namespace Undersoft.AMS.Service.Contracts
{
    public class Activity : ActivityBase
    {
        public virtual IdentifierSet<ActivityBase>? Identifiers { get; set; }

        public virtual Listing<ActivityBase>? RelatedFrom { get; set; }

        public virtual Listing<ActivityBase>? RelatedTo { get; set; }

        public virtual Listing<Item>? Items { get; set; }

        [Remote]
        public virtual Listing<ParticipantBase>? Participants { get; set; }

        [Remote]
        public virtual Listing<Resource>? Resources { get; set; }
    }
}