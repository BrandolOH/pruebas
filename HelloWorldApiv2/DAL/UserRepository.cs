using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.Models;


namespace HelloWorldApiv2.DAL
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        public IEnumerable<UserDto> GetUsers()
        {
            return context.Users
                .Select(user => new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Phone = user.Phone,
                    Country = user.Country
                })
                .ToList();
        }
    }
}
