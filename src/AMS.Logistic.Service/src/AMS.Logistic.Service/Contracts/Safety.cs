// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Logistic.Service.Application
// *************************************************

using Undersoft.SDK.Service.Data.Contract;

namespace Undersoft.AMS.Logistic.Service.Contracts
{
    /// <summary>
    /// The contact address.
    /// </summary>
    public class Safety : DataObject, IContract
    {
        public int? ExpirationDays { get; set; }

        public string? Description { get; set; }

        public float? Temperature { get; set; }

        public long? VaccineId { get; set; }
    }
}