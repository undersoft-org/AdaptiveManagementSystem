// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service.Application
// *************************************************

using Undersoft.AMS.Document.Domain.Entities.Catalogs;

namespace Undersoft.AMS.Document.Domain.Entities
{
    /// <summary>
    /// The contact address.
    /// </summary>
    public class Safety : Entity
    {
        public int? ExpirationDays { get; set; }

        public string? Description { get; set; }

        public float? Temperature { get; set; }

        public long? VaccineId { get; set; }

        public virtual Vaccine? Vaccine { get; set; }
    }
}