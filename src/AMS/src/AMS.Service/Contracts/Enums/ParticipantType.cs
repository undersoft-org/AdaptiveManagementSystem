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
    public enum ParticipantType : long
    {
        None = 0b_0000_0000,
        Organization = 0b_0000_0001,
        Person = 0b_0000_0010,
        Storage = 0b_0000_0100,
        Market = 0b_0000_1000,
        Carrier = 0b_0001_0000,
        Contractor = 0b_0010_0000,
        Contributor = 0b_0100_0000,
        Team = 0b_1000_0000,
        Facility = 0b_0001_0000_0000,
        Personel = 0b_0010_0000_0000,
        Division = 0b_0100_0000_0000,
        Environment = 0b_1000_0000_0000,
        Member = 0b_0001_0000_0000_0000,
        User = 0b_0010_0000_0000_0000,
        Guest = 0b_0100_0000_0000_0000,
        Customer = 0b_0000_0000_0000_0000,
        Supplier = 0b_0000_0000_0000_0000,
        Subcontractor = 0b_0000_0000_0000_0000,
    }
}