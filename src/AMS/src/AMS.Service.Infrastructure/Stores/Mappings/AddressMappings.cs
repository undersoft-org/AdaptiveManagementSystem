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
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Infrastructure.Database;
    using Undersoft.AMS.Domain.Entities;

    public class AddressMappings : EntityTypeMapping<Address>
    {
        const string TABLE_NAME = "Addresses";

        public override void Configure(EntityTypeBuilder<Address> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder
           .RelateOneToOne<Address, Place>(
               l => l.Address,
               r => r.Place,
               ExpandSite.OnRight,
               true
           );
        }
    }
}
