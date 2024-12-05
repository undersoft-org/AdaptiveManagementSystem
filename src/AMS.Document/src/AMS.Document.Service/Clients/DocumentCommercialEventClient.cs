using Microsoft.OData.Edm;
using Undersoft.AMS.Document.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Document.Service.Clients
{
    public class DocumentCommercialEventClient : DataClient<IDocumentCommercialEventStore>
    {
        public DocumentCommercialEventClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {
            return base.OnModelCreating(builder);
        }
    }
}