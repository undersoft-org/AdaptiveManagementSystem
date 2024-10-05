// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

namespace Undersoft.AMS.Domain.Entities
{
    public class Place : SDK.Service.Access.Identity.Place, IEntity
    {
        public virtual long? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public virtual long? AddressId { get; set; }
        public virtual Location? Address { get; set; }
    }
}