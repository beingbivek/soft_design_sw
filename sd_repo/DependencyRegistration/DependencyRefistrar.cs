using sd_repo.Repositories.GenericRepository;
using sd_repo.Repositories.StudentRepo;
using sd_repo.Repositories.UnitOfWorks;

namespace sd_repo.DependencyRegistration
{
    public class DependencyRefistrar
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            //Common
            services.AddScoped(typeof(iRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Repository
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

            //Service
        }
    }
}
