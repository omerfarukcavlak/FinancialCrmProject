using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinancialCRM.DataAccess.Contexts
{
    public class BankDbContextFactory : IDesignTimeDbContextFactory<BankDbContext>
    {
        public BankDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankDbContext>();
            optionsBuilder.UseSqlServer("Server=CAVLAK\\SQLEXPRESS;Database=FinancialCRM;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.UseLazyLoadingProxies();

            return new BankDbContext(optionsBuilder.Options);
        }
    }
}
