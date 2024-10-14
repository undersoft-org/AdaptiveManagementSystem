using Microsoft.OData.Edm;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts;
using Undersoft.SDK.Service.Data.Remote;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************

namespace Undersoft.AMS.Service.Clients
{
    public class CatalogClient : DataClient<ICatalogStore>
    {
        public CatalogClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {
            this.RemoteSetToSet<Participant, Resource>(rl => rl.RightEntityId, k => k.Id)
                .RemoteSetToSet<Subject, Resource>(rl => rl.RightEntityId, k => k.Id);

            return base.OnModelCreating(builder);
        }
    }
}
