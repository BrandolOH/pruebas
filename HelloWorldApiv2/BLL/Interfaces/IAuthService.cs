using HelloWorldApiv2.DTO.Interfaces;

namespace HelloWorldApiv2.BLL.Interfaces
{
    public interface IAuthService
    {
        Task<string> Login(string email, string password);
        Task Register(RegisterDto dto);
    }
}
