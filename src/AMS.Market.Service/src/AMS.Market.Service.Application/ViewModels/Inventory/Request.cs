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

namespace Undersoft.AMS.Market.Service.Application.ViewModels.Inventory
{
    public class Request : DataObject, IViewModel
    {
        public virtual string? Notes { get; set; }

        public long? StockId { get; set; }

        [Extended]
        public virtual Stock? Stock { get; set; }

        [VisibleRubric]
        [DisplayRubric("Quantity")]
        public virtual float? Quentity { get; set; }
    }

}
