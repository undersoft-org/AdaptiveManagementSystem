﻿using Microsoft.OData.Edm;
using Undersoft.SDK.Service.Data.Store;


// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************


namespace Undersoft.AMS.Catalog.Service.Clients
{
    public class ParticipantEventClient : DataClient<IEventStore>
    {
        public ParticipantEventClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {

            return base.OnModelCreating(builder);
        }
    }
}