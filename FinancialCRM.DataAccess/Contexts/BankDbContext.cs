using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Contexts
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankProcess> BankProcesses { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Spending> Spendings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Bank>().HasKey(b => b.Id);
            modelBuilder.Entity<BankProcess>().HasKey(bp => bp.Id);
            modelBuilder.Entity<Bill>().HasKey(b => b.Id);
            modelBuilder.Entity<Spending>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);


            modelBuilder.Entity<BankProcess>().HasOne(bp => bp.Bank).WithMany(b => b.BankProcesses).HasForeignKey(bp => bp.BankId);
            modelBuilder.Entity<Spending>().HasOne(s => s.Category).WithMany(c => c.Spendings).HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Bank>().Property(b => b.AccountNumber).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Bank>().Property(b => b.Title).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Bank>().Property(b => b.Balance).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BankProcess>().Property(bp => bp.Description).HasColumnType("nvarchar(250)");
            modelBuilder.Entity<BankProcess>().Property(bp => bp.ProcessDate).HasColumnType("date");
            modelBuilder.Entity<BankProcess>().Property(bp => bp.ProcessType).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<BankProcess>().Property(bp => bp.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Bill>().Property(b => b.Title).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Bill>().Property(b => b.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Bill>().Property(b => b.Period).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Spending>().Property(s => s.Title).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Spending>().Property(s => s.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Spending>().Property(s => s.Date).HasColumnType("date");
            modelBuilder.Entity<User>().Property(u => u.Username).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnType("nvarchar(50)");

            base.OnModelCreating(modelBuilder);

        }
    }
}
