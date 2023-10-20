using CSVReader.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSVReader.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-5HCBVC7\MSSQLSERVER01; Database=Synel; Trusted_Connection=true; TrustServerCertificate=true;");
    }
}
