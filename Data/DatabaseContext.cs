using Microsoft.EntityFrameworkCore;
using SpiritPenguin.Data.Entities;

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
    }    
}
