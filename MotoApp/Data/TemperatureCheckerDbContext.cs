using Microsoft.EntityFrameworkCore;
using TemperatureChecker.Entities;

namespace MotoApp.Data
{
    public class TemperatureCheckerDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<BusinessPartner> BusinessPartner => Set<BusinessPartner>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }


    }
}
