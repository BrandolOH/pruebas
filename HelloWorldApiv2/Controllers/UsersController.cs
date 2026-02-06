using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        public new class User
        {
            public required int Id { get; set; }
            public required string Name { get; set; }
            public required string Phone { get; set; }
            public required string Country { get; set; }
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Juan Pérez", Phone = "555-1234", Country = "México" },
                new User { Id = 2, Name = "María López", Phone = "555-5678", Country = "Colombia" },
                new User { Id = 3, Name = "Carlos Sánchez", Phone = "555-9012", Country = "España" },
                new User { Id = 4, Name = "Ana Torres", Phone = "555-3456", Country = "Argentina" }
            };

            return Ok(users);
        }
    }
}
