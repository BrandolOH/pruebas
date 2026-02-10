using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserDto> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
