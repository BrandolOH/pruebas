using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.DTO.Interfaces;
using HelloWorldApiv2.Models;
using Microsoft.AspNetCore.Identity;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;

    public AuthService(UserManager<ApplicationUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task Register(RegisterDto dto)
    {
        var user = new ApplicationUser
        {
            UserName = dto.Email,
            Email = dto.Email,
            Name = dto.Name,
            Phone = dto.Phone,
            Country = dto.Country
        };

        var result = await _userManager.CreateAsync(user, dto.Password);

        if (!result.Succeeded)
        {
            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }
    }

    public async Task<string> Login(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);

        if (user == null)
            throw new Exception("Usuario no encontrado");

        var valid = await _userManager.CheckPasswordAsync(user, password);

        if (!valid)
            throw new Exception("Password incorrecto");

        return await _tokenService.GenerateToken(user);
    }
}