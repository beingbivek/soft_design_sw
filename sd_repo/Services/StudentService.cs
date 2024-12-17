using sd_repo.Model;
using sd_repo.Repositories.StudentRepo;

namespace sd_repo.Services
{
    public class StudentService: IStudentService
    {
        #region Ctor and Properties

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        #endregion

        #region Method

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var data = await _studentRepository.GetByIdAsync(id).ConfigureAwait(false);
            return data;
        }

        #endregion
    }
}
