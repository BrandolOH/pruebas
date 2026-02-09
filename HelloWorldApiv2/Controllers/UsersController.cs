using Microsoft.AspNetCore.Mvc;
using HelloWorldApiv2.BLL;
using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
    }
}
