// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service
// *************************************************

using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Service.Contracts
{
    public class Phone : SDK.Service.Access.Identity.Phone, IContract
    {
        public virtual long? ParticipantId { get; set; }     
    }
}