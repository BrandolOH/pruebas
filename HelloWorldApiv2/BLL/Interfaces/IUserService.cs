using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetUsers();
    }
}