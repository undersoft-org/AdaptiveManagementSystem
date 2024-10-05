// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog.Service.Application
// *************************************************

using Undersoft.SDK.Service.Data.Contract;
using Undersoft.AMS.Catalog.Domain.Entities.Enums;

namespace Undersoft.AMS.Catalog.Service.Contracts
{
    public class Personal : SDK.Service.Access.Identity.Personal, IContract
    {
        public IdentifierType IdentifierType { get; set; }

        public string? Identifier { get; set; } = default!;

        public long? AppointmentId { get; set; }

        public virtual long? CertificateId { get; set; }

        public virtual long? PostSymptomId { get; set; }
    }
}