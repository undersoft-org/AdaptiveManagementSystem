using Microsoft.EntityFrameworkCore;
using Undersoft.AMS.Domain.Entities;
using Undersoft.AMS.Service.Infrastructure.Stores.Mappings;

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
    public class StoreBase<TStore, TContext> : DbStore<TStore, TContext>
        where TStore : IDataServerStore
        where TContext : DbContext
    {
        public StoreBase(DbContextOptions<TContext> options) : base(options) { }

        public virtual DbSet<Activity>? Activities { get; set; }
        public virtual DbSet<Address>? Addresses { get; set; }
        public virtual DbSet<Amount>? Amounts { get; set; }
        public virtual DbSet<Date>? Dates { get; set; }
        public virtual DbSet<Email>? Emails { get; set; }
        public virtual DbSet<Item>? Items { get; set; }
        public virtual DbSet<Participant>? Participants { get; set; }
        public virtual DbSet<Phone>? Phones { get; set; }
        public virtual DbSet<Resource>? Resources { get; set; }
        public virtual DbSet<Subject>? Subjects { get; set; }
        public virtual DbSet<Location>? Locations { get; set; }
        public virtual DbSet<Endpoint>? Endpoints { get; set; }
        public virtual DbSet<Place>? Places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyMapping(new SubjectMappings());
            modelBuilder.ApplyMapping(new ResourceMappings());
            modelBuilder.ApplyMapping(new AmountMappings());
            modelBuilder.ApplyMapping(new DateMappings());
            modelBuilder.ApplyMapping(new EmailMappings());
            modelBuilder.ApplyMapping(new ItemMappings());
            modelBuilder.ApplyMapping(new ParticipantMappings());
            modelBuilder.ApplyMapping(new PhoneMappings());
            modelBuilder.ApplyMapping(new AddressMappings());
            modelBuilder.ApplyMapping(new ActivityMappings());
            modelBuilder.ApplyMapping(new LocationMappings());
            modelBuilder.ApplyMapping(new EnpointMappings());
            modelBuilder.ApplyMapping(new PlaceMappings());

            base.OnModelCreating(modelBuilder);
        }
    }
}