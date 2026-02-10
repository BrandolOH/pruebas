namespace HelloWorldApiv2.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Phone { get; set; }

        public required string Country { get; set; }
    }
}
