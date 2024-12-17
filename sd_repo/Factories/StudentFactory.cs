using sd_repo.Dto;

namespace sd_repo.Factories
{
    public class StudentFactory : IStudentFactory
    {
        public StudentDto MapStudentEntityToDto(StudentDto entity)
        {
            StudentDto dto = new();
            {
                dto.FirstName = entity.FirstName;
                dto.Email = entity.Email;
                dto.Address = entity.Address;
            }
            return dto;
        }
    }
}
