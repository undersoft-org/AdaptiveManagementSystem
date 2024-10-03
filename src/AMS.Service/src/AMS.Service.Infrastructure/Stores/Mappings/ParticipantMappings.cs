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

    public class ParticipantMappings : EntityTypeMapping<Participant>
    {
        const string TABLE_NAME = "Participants";

        public override void Configure(EntityTypeBuilder<Participant> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);

            ModelBuilder
                .ApplyIdentifiers<Participant>()
                .RelateSetToSet<Participant, Participant>(
                    rm => rm.RelatedFrom,
                    nameof(Participant),
                    rm => rm.RelatedTo,
                    nameof(Participant),
                    ExpandSite.OnRight
                )
                .RelateSetToSet<Participant, Resource>(
                    r => r.Participants,
                    r => r.Resources,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Item>(
                    r => r.Participant,
                    r => r.Items,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Email>(
                    r => r.Participant,
                    r => r.Emails,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Phone>(
                    r => r.Participant,
                    r => r.Phones,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Address>(
                    r => r.Participant,
                    r => r.Addresses,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Date>(
                    r => r.Participant,
                    r => r.Dates,
                    ExpandSite.OnRight,
                    true
                )
                .RelateOneToSet<Participant, Amount>(
                    l => l.Participant,
                    r => r.Amounts,
                    ExpandSite.OnRight,
                    true
                );
        }
    }
}
