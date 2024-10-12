using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service.Infrastructure
// ********************************************************

namespace Undersoft.AMS.Service.Infrastructure.Stores.Mappings
{
    using Undersoft.AMS.Domain.Entities;    
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Infrastructure.Database;
    using Undersoft.SDK.Service.Infrastructure.Database.Relation;

    public class LocationMappings : EntityTypeMapping<Location>
    {
        const string TABLE_NAME = "Locations";

        public override void Configure(EntityTypeBuilder<Location> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder                
                .RelateOneToSet<Location, Place>(
                    l => l.Location,
                    r => r.Places,
                    ExpandSite.OnRight,
                    true
                ).RelateOneToSet<Location, Endpoint>(
                    l => l.Location,
                    r => r.Endpoints,
                    ExpandSite.OnRight,
                    true
                );
        }
    }
}
