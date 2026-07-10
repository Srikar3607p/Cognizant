using Microsoft.AspNetCore.Mvc;
using StudentAPI.DTOs;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController : ControllerBase
    {
        private StudentService studentService = new StudentService();

        [HttpGet]
        public ActionResult<List<StudentResponse>> GetStudents()
        {
            return Ok(studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public ActionResult<StudentResponse> GetStudentById(int id)
        {
            StudentResponse student = studentService.GetStudentById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public ActionResult<StudentResponse> AddStudent(StudentRequest request)
        {
            StudentResponse student = studentService.AddStudent(request);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public ActionResult<StudentResponse> UpdateStudent(int id, StudentRequest request)
        {
            StudentResponse student = studentService.UpdateStudent(id, request);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            return studentService.DeleteStudent(id) ? NoContent() : NotFound();
        }
    }
}
