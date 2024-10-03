using Microsoft.EntityFrameworkCore;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service.Infrastructure
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Infrastructure.Stores
{
    public class EventStore : DbStore<IEventStore, EventStore>
    {
        public EventStore(DbContextOptions<EventStore> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyMapping(new DbEventStoreMappings());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Event>? Events { get; set; }
    }
}