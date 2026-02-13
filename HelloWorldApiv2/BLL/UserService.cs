using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public IEnumerable<UserDto> GetUsers()
        {
            return userRepository.GetUsers()
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
