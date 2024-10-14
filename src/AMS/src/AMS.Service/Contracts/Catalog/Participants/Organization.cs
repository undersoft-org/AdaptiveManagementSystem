// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

namespace Undersoft.AMS.Service.Contracts.Catalog.Participants
{
    public class Organization : Participant
    {
        public Organization() { Type |= Domain.Entities.Enums.ParticipantType.Organization; }
    }
}