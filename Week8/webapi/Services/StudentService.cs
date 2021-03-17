using System.Collections.Generic;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public List<StudentModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentModel>();

        foreach (var student in _repository.GetAllStudents())
        {
            studentViewModels.Add(new StudentModel{
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
                Special = StudentRules.IsSpecial(student),
            });
        }

        return studentViewModels;
    }
}