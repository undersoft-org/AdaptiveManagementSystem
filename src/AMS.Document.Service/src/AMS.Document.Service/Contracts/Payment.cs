// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Document
// *************************************************

using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Document.Service.Contracts
{
    public class Payment : DataObject, IContract
    {
        public virtual string? Name { get; set; }

        public virtual double? Value { get; set; }

        public virtual double? Tax { get; set; }

        public virtual double? Amount { get; set; }

        public virtual long? CertificateId { get; set; }
    }
}
