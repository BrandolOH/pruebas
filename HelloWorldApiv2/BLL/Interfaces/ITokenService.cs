using HelloWorldApiv2.Models;

namespace HelloWorldApiv2.BLL.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateToken(ApplicationUser user);
    }
}
