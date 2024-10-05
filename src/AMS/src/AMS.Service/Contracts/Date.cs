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
    public class Date : SDK.Service.Access.Identity.Date, IContract
    {
        public virtual long? ParticipantId { get; set; }      

        public virtual long? ItemId { get; set; }     

        public virtual long? ActivityId { get; set; }      

        public virtual long? AmountId { get; set; }      
    }
}