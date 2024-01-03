using Microsoft.AspNetCore.Mvc;
using TestTask.Server.Entities;
using TestTask.Server.Services;

namespace TestTask.Server.Controllers
{
    [Route("Api/UserController")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] User user)
        {
            var loggedIn = (_operations as UserService).SuccessfulLogin(user); 
            return Ok(loggedIn);
        }

        private IOperations<User> _operations;

        public UserController(IOperations<User> operations)
        {
            this._operations = operations;
        }

        [HttpGet]
        public IActionResult GetUsersCollection()
        {
            return Ok(this._operations.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = this._operations.Get(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound($"User with id:{id} was not found");
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            this._operations.Create(user);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
                HttpContext.Request.Path + '/' + user.Id, user);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var userToDelete = this._operations.Get(id);
            if (userToDelete != null)
            {
                this._operations.Delete(id);
                return Ok(userToDelete);
            }
            return NotFound($"User with id:{id} was not found");
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult EditUser(int id, [FromBody] User user)
        {
            var userToEdit = this._operations.Get(id);
            if (userToEdit != null)
            {
                user.Id = userToEdit.Id;
                return Ok(this._operations.Update(userToEdit));
            }
            return NotFound($"User with id:{id} was not found");
        }
    }
}
