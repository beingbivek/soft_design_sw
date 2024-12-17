using sd_repo.Factories;
using sd_repo.Repositories.GenericRepository;
using sd_repo.Repositories.StudentRepo;
using sd_repo.Repositories.UnitOfWorks;
using sd_repo.Services;

namespace sd_repo.DependencyRegistration
{
    public class DependencyRegistrar
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            //Common
            services.AddScoped(typeof(iRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Repository
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

            //Service
            services.AddScoped(typeof(IStudentService), typeof(StudentService));

            //Factory
            services.AddScoped(typeof(IStudentFactory), typeof(StudentFactory));
        }
    }
}
