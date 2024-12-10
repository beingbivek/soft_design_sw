using Microsoft.EntityFrameworkCore;
using sd_repo.Data;

namespace sd_repo.Repositories.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region ctor and properties - ctor is constructor
        private readonly DbSet<T> _dbSet;
        public Repository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }
        #endregion

        #region

        #endregion
    }
}
