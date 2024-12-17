using sd_repo.Model;

namespace sd_repo.Services
{
    public interface IStudentService
    {
        Task<Student> GetStudentByIdAsync(int id);
    }
}
