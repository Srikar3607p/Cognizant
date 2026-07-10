using StudentAPI.Data;
using StudentAPI.DTOs;
using StudentAPI.Models;

namespace StudentAPI.Services
{
    public class StudentService
    {
        private static AppDbContext db = new AppDbContext();
        private static int nextId = 1;

        public List<StudentResponse> GetStudents()
        {
            return db.Students.Select(ToResponse).ToList();
        }

        public StudentResponse GetStudentById(int id)
        {
            Student student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return null;
            }

            return ToResponse(student);
        }

        public StudentResponse AddStudent(StudentRequest request)
        {
            Student student = new Student
            {
                Id = nextId,
                Name = request.Name,
                Age = request.Age,
                Department = request.Department
            };

            nextId++;
            db.Students.Add(student);

            return ToResponse(student);
        }

        public StudentResponse UpdateStudent(int id, StudentRequest request)
        {
            Student student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return null;
            }

            student.Name = request.Name;
            student.Age = request.Age;
            student.Department = request.Department;

            return ToResponse(student);
        }

        public bool DeleteStudent(int id)
        {
            Student student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return false;
            }

            db.Students.Remove(student);
            return true;
        }

        private StudentResponse ToResponse(Student student)
        {
            return new StudentResponse
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                Department = student.Department
            };
        }
    }
}
