// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Application
// *************************************************

namespace Undersoft.AMS.Service.Contracts.Catalog.Participants
{
    public class Contractor : Participant
    {
        public Contractor() { Type |= Domain.Entities.Enums.ParticipantType.Contractor; }
    }
}