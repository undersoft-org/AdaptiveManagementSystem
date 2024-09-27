// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market
// *************************************************

using Undersoft.AMS.Market.Domain.Entities.Enums;
using Undersoft.AMS.Market.Domain.Entities.Vaccination;

namespace Undersoft.AMS.Market.Domain.Entities
{
    public class Schedule : Entity, IEntity
    {
        public virtual string? Notes { get; set; }

        public virtual ScheduleType Type { get; set; }

        public virtual DateTime? StartDate { get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual TimeOnly? StartTime { get; set; }

        public virtual TimeOnly? EndTime { get; set; }

        public virtual TimeSpan? Interval { get; set; }

        public virtual long? AppointmentId { get; set; }

        public virtual Appointment? Appointment { get; set; }
    }
}
