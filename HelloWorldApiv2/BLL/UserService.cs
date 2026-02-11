using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public IEnumerable<IUserDto> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
