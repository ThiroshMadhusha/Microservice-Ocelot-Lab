namespace Sliit.MTIT.Student.Services
{
    public interface IStudentService
    {
        List<Models.Student> GetStudents();

        Models.Student? GetStudent(int id);

        Models.Student? AddStudent(Models.Student student);

        Models.Student? UpdateStudent(Models.Student student);

        bool? DeleteStudent(int id);

    }
}
