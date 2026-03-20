
namespace HelloWorldApiv2.DTO.Interfaces
{
    public class RegisterDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Country { get; set; }
    }
}
