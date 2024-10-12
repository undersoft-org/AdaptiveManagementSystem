using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Undersoft.AMS.Service.Infrastructure.Stores.Mappings
{
    using Undersoft.AMS.Domain.Entities;    
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Infrastructure.Database;

    public class ResourceMappings : EntityTypeMapping<Resource>
    {
        const string TABLE_NAME = "Resources";

        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder.RelateOneToOne<Resource, Location>(
                r => r.Resource,
                l => l.Location,
                ExpandSite.OnRight,
                true
            );
        }
    }
}
