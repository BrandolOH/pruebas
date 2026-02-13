using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL.Interface
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetUsers();
    }
}
