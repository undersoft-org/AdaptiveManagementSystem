// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Endpoint : SDK.Service.Access.Identity.Endpoint, IEntity
    {
        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }
    }
}