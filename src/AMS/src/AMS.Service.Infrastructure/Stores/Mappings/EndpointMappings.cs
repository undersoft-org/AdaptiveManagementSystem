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

    public class EnpointMappings : EntityTypeMapping<Endpoint>
    {
        const string TABLE_NAME = "Endpoints";

        public override void Configure(EntityTypeBuilder<Endpoint> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);           
        }
    }
}
