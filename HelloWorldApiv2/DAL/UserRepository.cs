using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;


namespace HelloWorldApiv2.DAL
{
    public class UserRepository(IDbContextFactory<AppDbContext> factory) : IUserRepository
    {
        public IQueryable<User> GetUsers()
        {
            var context = factory.CreateDbContext();

            return context.Users.AsNoTracking();
        }
    }
}
