using Microsoft.OData.Edm;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Clients
{
    public class EventClient : DataClient<IEventStore>
    {
        public EventClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {
            return base.OnModelCreating(builder);
        }
    }
}