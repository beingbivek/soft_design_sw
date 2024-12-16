using sd_repo.Repositories.UnitOfWorks;

namespace sd_repo.Repositories.GenericRepository
{
    public interface iRepository<T> : IUnitOfWork where T : class
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
    }
}
