using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Student.Data;
using Sliit.MTIT.Student.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService ?? throw new ArgumentNullException(nameof(studentService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetStudents());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _studentService.GetStudent(id) != null ? Ok(_studentService.GetStudent(id)) : NoContent();
        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Student student)
        {
            return Ok(_studentService.AddStudent(student));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Student student)
        {
            return Ok(_studentService.UpdateStudent(student));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _studentService.DeleteStudent(id);

            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student with ID:{id}.");
        }
    }
}
