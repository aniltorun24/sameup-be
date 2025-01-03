using System.Reflection;
using GGlease.Model.DB;
using GGlease.Model.DB.Generic;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Currencies = Set<Currency>();
            MaturityOptions = Set<MaturityOption>();
            EquipmentGroups = Set<EquipmentGroup>();
            Equipments = Set<Equipment>();
            SellerCompanies = Set<SellerCompany>();
            EquipmentSellerCompanies = Set<EquipmentSellerCompany>();
            ApplicationForms = Set<ApplicationForm>();
            FinancialCompanies = Set<FinancialCompany>();
            Offers = Set<Offer>();
            Rates = Set<Rate>();
            Users = Set<User>();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var utcNow = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseEntity trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.UpdatedOn = utcNow;
                            entry.Property("CreatedOn").IsModified = false;
                            break;

                        case EntityState.Added:
                            trackable.CreatedOn = utcNow;
                            trackable.UpdatedOn = utcNow;
                            break;
                    }
                }
            }
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<MaturityOption> MaturityOptions { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentGroup> EquipmentGroups { get; set; }
        public DbSet<SellerCompany> SellerCompanies { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<FinancialCompany> FinancialCompanies { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<EquipmentSellerCompany> EquipmentSellerCompanies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}