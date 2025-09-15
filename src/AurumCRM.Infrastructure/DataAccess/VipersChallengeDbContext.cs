using Microsoft.EntityFrameworkCore;

namespace AurumCRM.Infrastructure.DataAccess;

public class AurumCRMDbContext(DbContextOptions options) : DbContext(options)
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AurumCRMDbContext).Assembly);
    }
}
