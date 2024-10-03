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

    public class ActivityMappings : EntityTypeMapping<Activity>
    {
        const string TABLE_NAME = "Activities";

        public override void Configure(EntityTypeBuilder<Activity> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder
                .ApplyIdentifiers<Activity>()
                .RelateSetToSet<Activity, Activity>(
                    rm => rm.RelatedFrom,
                    nameof(Activity),
                    rm => rm.RelatedTo,
                    nameof(Activity),
                    ExpandSite.OnRight
                )
                .RelateSetToSet<Activity, Resource>(
                    r => r.Activities,
                    r => r.Resources,
                    ExpandSite.OnRight
                )
                .RelateSetToSet<Activity, Participant>(
                    l => l.Activities,
                    r => r.Participants,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Activity, Item>(
                    r => r.Activity,
                    r => r.Items,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Activity, Date>(
                    r => r.Activity,
                    r => r.Dates,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Activity, Amount>(
                    l => l.Activity,
                    r => r.Amounts,
                    ExpandSite.OnRight,
                    true
                );
        }
    }
}
