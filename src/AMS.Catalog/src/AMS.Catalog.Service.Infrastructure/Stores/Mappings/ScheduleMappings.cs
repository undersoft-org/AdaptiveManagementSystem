﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SCC.Service.Infrastructure
// ********************************************************

namespace Undersoft.AMS.Catalog.Service.Infrastructure.Stores.Mappings
{
    using Undersoft.SDK.Service.Data.Store;
    using Undersoft.SDK.Service.Infrastructure.Database;
    using Undersoft.AMS.Catalog.Domain.Entities;

    /// <summary>
    /// The contact mappings.
    /// </summary>
    public class ScheduleMappings : EntityTypeMapping<Schedule>
    {
        const string TABLE_NAME = "Schedules";

        /// <summary>
        /// TODO: Add Summary.
        /// </summary>
        /// <param name="typeBuilder">The type builder.</param>
        public override void Configure(EntityTypeBuilder<Schedule> typeBuilder)
        {
            typeBuilder.ToTable(TABLE_NAME, DataStoreSchema.DomainSchema);
        }
    }
}