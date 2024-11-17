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
    public class Participant : ParticipantBase
    {

        public virtual IdentifierSet<ParticipantBase>? Identifiers { get; set; }

        public virtual Listing<ParticipantBase>? RelatedFrom { get; set; }

        public virtual Listing<ParticipantBase>? RelatedTo { get; set; }       

        [Remote]
        public virtual RemoteSet<Resource>? Resources { get; set; }
    }
}
