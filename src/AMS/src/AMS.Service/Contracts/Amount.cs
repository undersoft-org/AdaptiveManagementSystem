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
    public class Amount : DataObject, IContract
    {
        public virtual AmountType Type { get; set; }

        public virtual UnitType Unit { get; set; }

        public virtual string? Name { get; set; }

        public virtual string? UnitName { get; set; }

        public virtual double? Prevalue { get; set; }

        public virtual double? Factor { get; set; }

        public virtual double? Value { get; set; }

        public virtual long? ParticipantId { get; set; }      

        public virtual long? ItemId { get; set; }
     
        public virtual long? ActivityId { get; set; }   

        public virtual long? SubjectId { get; set; }      

        public virtual Listing<Date>? Dates { get; set; }
    }
}