using Microsoft.AspNetCore.Mvc;
using TestTask.Server.Entities;
using TestTask.Server.Services;

namespace TestTask.Server.Controllers
{
    [Route("Api/StudentController")]
    public class StudentController : ControllerBase
    {
        private IOperations<Student> _operations;

        public StudentController(IOperations<Student> operations)
        {
            this._operations = operations;
        }

        [HttpGet]
        public IActionResult GetStudentsCollection()
        {
            return Ok(this._operations.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = this._operations.Get(id);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound($"Student with id:{id} was not found");
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            this._operations.Create(student);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
                HttpContext.Request.Path + '/' + student.Id, student);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var studentToDelete = this._operations.Get(id);
            if (studentToDelete != null)
            {
                this._operations.Delete(id);
                return Ok(studentToDelete);
            }
            return NotFound($"Student with id:{id} was not found");
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult EditStudent(int id, [FromBody] Student student)
        {
            var studentToEdit = this._operations.Get(id);
            if (studentToEdit != null)
            {
                student.Id = studentToEdit.Id;
                return Ok(this._operations.Update(student));
            }
            return NotFound($"Student with id:{id} was not found");
        }
    }
}
