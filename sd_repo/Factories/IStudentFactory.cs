using sd_repo.Dto;

namespace sd_repo.Factories
{
    public interface IStudentFactory
    {
        StudentDto.MapStudentEntityToDto(Student entity);
    }
}
