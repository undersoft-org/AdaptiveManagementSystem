// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Access.Identity;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Data.Identifier;
using Undersoft.SDK.Service.Data.Remote.Repository;
using Undersoft.SDK.Service.Data.Remote;

namespace Undersoft.AMS.Service.Contracts
{
    public class ParticipantBase : DataObject, IContract
    {
        public virtual ParticipantType Type { get; set; }

        public virtual string? Nickname { get; set; }

        public virtual string? FirstName { get; set; }

        public virtual string? LastName { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? FullName { get; set; }

        public virtual Listing<Email>? Emails { get; set; }

        public virtual Listing<Phone>? Phones { get; set; }

        public virtual Listing<Address>? Addresses { get; set; }

        public virtual Listing<Date>? Dates { get; set; }

        public virtual Listing<Amount>? Amounts { get; set; }

        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public virtual string? SocialMedia { get; set; }

        public virtual string? Websites { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
