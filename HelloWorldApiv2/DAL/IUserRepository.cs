using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.DAL
{
    public interface IUserRepository
    {
        IEnumerable<UserDto> GetUsers();
    }
}
