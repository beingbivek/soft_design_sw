using sd_repo.Data;
using sd_repo.Model;
using sd_repo.Repositories.GenericRepository;

namespace sd_repo.Repositories.StudentRepo
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
