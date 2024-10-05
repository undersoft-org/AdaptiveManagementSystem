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
    public class Email : SDK.Service.Access.Identity.Email, IContract
    {
        public virtual long? ParticipantId { get; set; }        
    }
}