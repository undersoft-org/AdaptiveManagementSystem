// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Identifier;
using Undersoft.SDK.Service.Data.Remote;
using Undersoft.SDK.Service.Data.Remote.Repository;

namespace Undersoft.AMS.Service.Contracts
{
    public class Subject : SubjectBase
    {
        public virtual IdentifierSet<SubjectBase>? Identifiers { get; set; }

        public virtual Listing<SubjectBase>? RelatedFrom { get; set; }

        public virtual Listing<SubjectBase>? RelatedTo { get; set; }               

        [Remote]
        public virtual RemoteSet<Resource>? Resources { get; set; }
    }
}