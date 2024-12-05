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
    public enum ResourceType : long
    {
        None = 0b_0000_0000,
        Image = 0b_0000_0001,
        File = 0b_0000_0010,
        Plugin = 0b_0000_0100,
        Document = 0b_0000_1000,
        Icon = 0b_0001_0000,
        Model = 0b_0010_0000,
        Movie = 0b_0100_0000,
        Script = 0b_1000_0000,
        Report = 0b_0001_0000_0000
    }
}