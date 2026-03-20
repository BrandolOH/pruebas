using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.Models;
using Microsoft.AspNetCore.Identity;

namespace HelloWorldApiv2.BLL
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<UserDto> GetUsers()
        {
            return _userManager.Users
                .Select(user => new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Phone = user.Phone,
                    Country = user.Country
                })
                .ToList();
        }
    }
}