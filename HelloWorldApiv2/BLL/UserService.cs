using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository =userRepository;

        public IEnumerable<UserDto> GetUsers()
        {
            return _userRepository.GetUsers()
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
