using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.DAL
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<UserDto> GetUsers()
        {
            return new List<UserDto>
            {
                new UserDto { Id = 1, Name = "Juan Pérez", Phone = "555-1234", Country = "México" },
                new UserDto { Id = 2, Name = "María López", Phone = "555-5678", Country = "Colombia" },
                new UserDto { Id = 3, Name = "Carlos Sánchez", Phone = "555-9012", Country = "España" },
                new UserDto { Id = 4, Name = "Ana Torres", Phone = "555-3456", Country = "Argentina" }
            };
        }
    }
}
