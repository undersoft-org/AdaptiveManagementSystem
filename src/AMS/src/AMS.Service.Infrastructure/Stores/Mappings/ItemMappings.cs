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
    using Undersoft.AMS.Service.Contracts;
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Infrastructure.Database;
    using Undersoft.SDK.Service.Infrastructure.Database.Relation;

    public class ItemMappings : EntityTypeMapping<Item>
    {
        const string TABLE_NAME = "Items";

        public override void Configure(EntityTypeBuilder<Item> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder              
                .RelateOneToSet<Item, Date>(
                    r => r.Item,
                    r => r.Dates,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Item, Amount>(
                    l => l.Item,
                    r => r.Amounts,
                    ExpandSite.OnRight,
                    true
                ).RelateOneToOne<Item, Location>(
                    l => l.Item,
                    r => r.Location,
                    ExpandSite.OnRight,
                    true
                );
        }
    }
}
