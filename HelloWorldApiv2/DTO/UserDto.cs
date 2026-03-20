namespace HelloWorldApiv2.DTO
{
    public class UserDto : IUserDto
    {
        public string Id { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Country { get; set; }
    }
}
