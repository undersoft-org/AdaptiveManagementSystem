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

    public class PhoneMappings : EntityTypeMapping<Phone>
    {
        const string TABLE_NAME = "Phones";

        public override void Configure(EntityTypeBuilder<Phone> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);
        }
    }
}
