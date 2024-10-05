// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS
// *************************************************

namespace Undersoft.AMS.Service.Contracts.Enums
{
    [Flags]
    public enum UnitType : long
    {
        None = 0b_0000_0000,
        Money = 0b_0000_0001,
        Weight = 0b_0000_0010,
        Length = 0b_0000_0100,
        Time = 0b_0000_1000
    }
}