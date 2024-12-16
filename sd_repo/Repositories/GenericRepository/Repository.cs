using Microsoft.EntityFrameworkCore;
using sd_repo.Data;
using sd_repo.Repositories.UnitOfWorks;

namespace sd_repo.Repositories.GenericRepository
{
    public class Repository<T> : UnitOfWork,iRepository<T> where T : class
    {
        #region ctor and properties - ctor is constructor
        private readonly DbSet<T> _dbSet;
        public Repository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }
        #endregion

        #region Implementation

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity).ConfigureAwait(false);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        #endregion
    }
}
