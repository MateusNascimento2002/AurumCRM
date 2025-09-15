using AurumCRM.Domain.Repositories.UnitOfWork;

namespace AurumCRM.Infrastructure.DataAccess;

internal class UnitOfWork(AurumCRMDbContext context) : IUnitOfWork
{
    public async Task CommitChanges()
    {
        await context.SaveChangesAsync();
    }
}