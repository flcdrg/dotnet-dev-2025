using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFCore;

public class AdventureWorksContext : DbContext
{
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = "localhost",
            InitialCatalog = "AdventureWorks",
            UserID = "sa",
            Password = "yourStrong(!)Password",
            TrustServerCertificate = true
        };

        optionsBuilder.UseSqlServer(builder.ConnectionString);
    }
}