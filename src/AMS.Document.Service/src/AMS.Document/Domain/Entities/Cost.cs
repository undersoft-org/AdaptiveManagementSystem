// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document
// *************************************************

using Undersoft.AMS.Document.Domain.Entities.Inventory;
using Undersoft.AMS.Document.Domain.Entities.Vaccination;

namespace Undersoft.AMS.Document.Domain.Entities
{
    public class Cost : Entity, IEntity
    {
        public virtual string? Name { get; set; }

        public virtual double? Value { get; set; }

        public virtual double? Tax { get; set; }

        public virtual double? Amount { get; set; }

        public virtual long? ProcedureId { get; set; }

        public virtual Procedure? Procedure { get; set; }

        public virtual long? TrafficId { get; set; }

        public virtual Traffic? Traffic { get; set; }
    }

}
