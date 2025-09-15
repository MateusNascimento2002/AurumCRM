namespace AurumCRM.Domain.Repositories.UnitOfWork;

public interface IUnitOfWork
{
    Task CommitChanges();
}
