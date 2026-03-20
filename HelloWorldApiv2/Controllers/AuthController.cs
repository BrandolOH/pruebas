using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.DTO.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            try
            {
                var token = await _authService.Login(dto.Email, dto.Password);

                return Ok(new
                {
                    token
                });
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    

    [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            await _authService.Register(dto);
            return Ok("Usuario creado");
        }
    }
}