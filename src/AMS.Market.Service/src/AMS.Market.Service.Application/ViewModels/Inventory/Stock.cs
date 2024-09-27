// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market
// *************************************************


// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market
// *************************************************

using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.AMS.Market.Service.Application.ViewModels.Catalogs;

namespace Undersoft.AMS.Market.Service.Application.ViewModels.Inventory
{
    public class Stock : DataObject, IViewModel
    {
        public virtual string? Notes { get; set; }

        public long? VaccineId { get; set; }

        [Extended]
        public virtual Vaccine? Vaccine { get; set; }

        public virtual float? Amount { get; set; }
    }

}
