// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog.Service.Application
// *************************************************

using Undersoft.AMS.Catalog.Domain.Entities.Enums;
using Undersoft.AMS.Catalog.Domain.Entities.Vaccination;

namespace Undersoft.AMS.Catalog.Domain.Entities
{
    public class Personal : SDK.Service.Access.Identity.Personal, IEntity
    {
        public IdentifierType IdentifierType { get; set; }

        public string? Identifier { get; set; } = default!;

        public long? AppointmentId { get; set; }

        public virtual Appointment? Appointment { get; set; }

        public virtual long? CertificateId { get; set; }

        public virtual Certificate? Certificate { get; set; }

        public virtual long? PostSymptomId { get; set; }

        public virtual PostSymptom? PostSymptom { get; set; }
    }
}