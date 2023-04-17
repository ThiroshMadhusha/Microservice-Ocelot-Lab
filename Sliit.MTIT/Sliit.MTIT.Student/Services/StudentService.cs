using Sliit.MTIT.Student.Data;
using Sliit.MTIT.Student.Models;

namespace Sliit.MTIT.Student.Services
{
    public class StudentService : IStudentService
    {
        public List<Models.Student> GetStudents()
        {
            return StudentMockDataService.Students;
        }

        public Models.Student? GetStudent(int id)
        {
            return StudentMockDataService.Students.FirstOrDefault(x => x.Id == id);
        }

        public Models.Student? AddStudent(Models.Student student)
        {
            StudentMockDataService.Students.Add(student);
            return student;
        }

        public Models.Student? UpdateStudent(Models.Student student)
        {
            Models.Student selectedStudent = StudentMockDataService.Students.FirstOrDefault(x => x.Id == student.Id);
            if (selectedStudent != null)
            {
                selectedStudent.Address = student.Address;
                selectedStudent.Age = student.Age;
                selectedStudent.Name = student.Name;
                return selectedStudent;
            }

            return selectedStudent;
        }

        public bool? DeleteStudent(int id)
        {
            Models.Student selectedStudent = StudentMockDataService.Students.FirstOrDefault(x => x.Id == id);
            if (selectedStudent != null)
            {
                StudentMockDataService.Students.Remove(selectedStudent);
                return true;
            }
            return false;
        }
    }
}
