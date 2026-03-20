using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<ApplicationUser> GetUsers()
        {
            return _context.Users.AsNoTracking();
        }
    }
}