// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Catalog
// *************************************************

using Microsoft.OData.ModelBuilder;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.AMS.Catalog.Service.Contracts.Catalogs;

namespace Undersoft.AMS.Catalog.Service.Contracts.Inventory
{
    public class Stock : DataObject, IContract
    {
        public virtual string? Notes { get; set; }

        public long? VaccineId { get; set; }

        [AutoExpand]
        public virtual Vaccine? Vaccine { get; set; }

        public virtual float? Amount { get; set; }
    }

}
