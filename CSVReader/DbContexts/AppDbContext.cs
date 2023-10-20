using CSVReader.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSVReader.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=db-postgresql-sgp1-36627-do-user-14651493-0.c.db.ondigitalocean.com; Port=25060; Database=synel-db; User Id=doadmin; Password=AVNS_dBBMG8VsyOPWcXmOZfK;");

        /*string connectionString = "Server=localhost; Port=5432; Database=synel-db; User Id=postgres; Password=12345";
        optionsBuilder.UseNpgsql(connectionString);*/

        //optionsBuilder.UseSqlServer(@"Server=DESKTOP-5HCBVC7\MSSQLSERVER01; Database=Synel; Trusted_Connection=true; TrustServerCertificate=true;");
    }
}
