using HelloWorldApiv2.Models;

namespace HelloWorldApiv2.DAL.Interface
{
    public interface IUserRepository
    {
        IQueryable<ApplicationUser> GetUsers();
    }
}
