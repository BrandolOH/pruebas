using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetUsers();
    }
}
