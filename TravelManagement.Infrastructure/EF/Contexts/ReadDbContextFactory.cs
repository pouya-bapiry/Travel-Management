using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;


namespace TravelManagement.Infrastructure.EF.Contexts
{
    public class ReadDbContextFactory
        : IDesignTimeDbContextFactory<ReadDbContext>
    {
        ReadDbContext IDesignTimeDbContextFactory<ReadDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReadDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.;Database=TravelManagement_ReadDb;Trusted_Connection=True;TrustServerCertificate=True"
            );

            return new ReadDbContext(optionsBuilder.Options);
        }
    }
}
