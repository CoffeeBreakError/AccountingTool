﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AccountingTool.DAL.Models;
using AccountingTool.DAL.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AccountingTool.DAL.EF.Context
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region DbSets

        public DbSet<Position> Positions { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            ChangeTracker.DetectChanges();

            List<EntityEntry<ISoftDeletable>> deletedEntities = ChangeTracker.Entries<ISoftDeletable>()
            .Where(e => e.State == EntityState.Deleted).ToList();
            deletedEntities.ForEach(e =>
            {
                e.State = EntityState.Unchanged;
                e.Entity.IsDeleted = true;
                
            });

            List<EntityEntry<IBaseEntity>> addedEntities = ChangeTracker.Entries<IBaseEntity>()
                .Where(e => e.State == EntityState.Added).ToList();
            addedEntities.ForEach(e =>
            {
                e.Entity.AddedDate = DateTime.UtcNow;
            });

            List<EntityEntry<IBaseEntity>> modifiedEntities = ChangeTracker.Entries<IBaseEntity>()
                .Where(e => e.State == EntityState.Modified).ToList();
            modifiedEntities.ForEach(e =>
            {
                e.Entity.ModifiedDate = DateTime.UtcNow;
            });
        }
    }
}