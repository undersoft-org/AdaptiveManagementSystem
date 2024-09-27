// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document.Service.Application
// *************************************************

using Undersoft.SDK.Service.Data.Contract;
using Undersoft.AMS.Document.Domain.Entities.Enums;

namespace Undersoft.AMS.Document.Service.Contracts
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