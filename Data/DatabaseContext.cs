using Microsoft.EntityFrameworkCore;
using SpiritPenguin.Data.Entities;
using System;
namespace SpiritPenguin.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        { }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseEstimate> ExpenseEstimates { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Picklist> Picklist { get; set; }
        public DbSet<PicklistType> PicklistTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var ExpenseCategoryId = new Guid ("b40ee6c6-3dc9-41e7-a2d0-350237306099");

            #region PicklistTypeSeed
            modelBuilder.Entity<PicklistType>().HasData(new PicklistType {Id = ExpenseCategoryId, Value= "ExpenseCategory", IsDeleted = false, CreatedDate= DateTime.Now});
            #endregion

            #region PicklistSeed
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("5cf235b2-a803-43d1-824d-38de32c83ccd"), PicklistTypeId = ExpenseCategoryId, Value="Bills", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("bfe3c2bb-0717-489d-8d6f-12979c61ab25"), PicklistTypeId = ExpenseCategoryId, Value="Rent", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("8c98085a-a16a-4115-a7d1-12f8a980de67"), PicklistTypeId = ExpenseCategoryId, Value="Other", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("67918693-1acb-4421-81bb-8be1ece04268"), PicklistTypeId = ExpenseCategoryId, Value="Entertainment", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("d0c9c322-5b5f-4766-b148-e7501492a954"), PicklistTypeId = ExpenseCategoryId, Value="Junk Food", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("763c0414-97ba-46cc-8846-2e03babbe0ba"), PicklistTypeId = ExpenseCategoryId, Value="Necessities", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("43f1b49f-a6a9-4072-b602-794263811372"), PicklistTypeId = ExpenseCategoryId, Value="Lifestyle", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("883c19f8-e2f2-4141-a96e-43dd5a80b45e"), PicklistTypeId = ExpenseCategoryId, Value="Developer", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("8574d514-d5a7-496b-a00a-3ac9d00a99f4"), PicklistTypeId = ExpenseCategoryId, Value="Loan repayment", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            modelBuilder.Entity<Picklist>().HasData(new Picklist() { Id = new Guid("7b3ce76b-4c69-4e94-8c61-a9dc415251cd"), PicklistTypeId = ExpenseCategoryId, Value="Automotive", CreatedDate = DateTime.Now, IsDeleted = false, IsActive = true });
            #endregion
        }
    }    
}










