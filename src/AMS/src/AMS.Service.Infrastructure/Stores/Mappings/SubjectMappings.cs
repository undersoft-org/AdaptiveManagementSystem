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

    public class SubjectMappings : EntityTypeMapping<Subject>
    {
        const string TABLE_NAME = "Subjects";

        public override void Configure(EntityTypeBuilder<Subject> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder
                .ApplyIdentifiers<Subject>()
                .RelateSetToSet<Subject, Subject>(
                    rm => rm.RelatedFrom,
                    nameof(Subject),
                    rm => rm.RelatedTo,
                    nameof(Subject),
                    ExpandSite.OnRight
                )
                .RelateSetToSet<Subject, Resource>(
                    r => r.Subjects,
                    r => r.Resources,
                    ExpandSite.OnRight
                )
                .RelateOneToSet<Subject, Item>(
                    r => r.Subject,
                    r => r.Items,
                    ExpandSite.OnLeft,
                    true
                )                          
                .RelateOneToSet<Subject, Amount>(
                    l => l.Subject,
                    r => r.Amounts,
                    ExpandSite.OnRight,
                    true
                ).RelateOneToOne<Subject, Location>(
                    l => l.Activity,
                    r => r.Location,
                    ExpandSite.OnRight,
                    true
                );
        }
    }
}
