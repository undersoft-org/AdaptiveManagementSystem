using Microsoft.OData.Edm;
using Undersoft.AMS.Catalog.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Catalog.Service.Clients
{
    public class CatalogSubjectsEventClient : DataClient<ICatalogSubjectsEventStore>
    {
        public CatalogSubjectsEventClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {
            return base.OnModelCreating(builder);
        }
    }
}