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
    public enum ItemType : long
    {
        None = 0b_0000_0000,
        Activity = 0b_0000_0001,
        Stock = 0b_0000_0010,
        Inventory = 0b_0000_0100
    }
}