// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS
// *************************************************

namespace Undersoft.AMS.Domain.Entities.Enums
{
    [Flags]
    public enum ActivityType : long
    {
        None = 0b_0000_0000_0000,
        Sale = 0b_0000_0000_0001,
        Order = 0b_0000_0000_0010,
        Offer = 0b_0000_0000_0100,
        Process = 0b_0000_0000_1000,
        Event = 0b_0000_0001_0000,
        Transaction = 0b_0000_0010_0000,
        Purchase = 0b_0000_0100_0000,
        Produce = 0b_0000_1000_0000,
        Consume = 0b_0001_0000_0000,
        Stock = 0b_0010_0000_0000,
        Inventory = 0b_0100_0000_0000,
        Delivery = 0b_1000_0000_0000,
        Shipment = 0b_0001_0000_0000_0000
    }
}