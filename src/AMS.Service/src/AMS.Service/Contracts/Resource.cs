// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************


using Undersoft.AMS.Domain.Entities.Enums;
using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Service.Contracts
{
    public class Resource : DataObject, IContract
    {
        public virtual ResourceType Type { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? Description { get; set; }

        public virtual string? Member { get; set; }

        public virtual byte[]? MemberData { get; set; }                  
    }
}