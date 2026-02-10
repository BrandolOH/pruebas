using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.DAL.Interface
{
    public interface IUserRepository
    {
        IEnumerable<UserDto> GetUsers();
    }
}
