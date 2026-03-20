    using Microsoft.AspNetCore.Identity;

    namespace HelloWorldApiv2.Models
    {
        public class ApplicationUser : IdentityUser
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Country { get; set; }

            public ICollection<Order> Orders { get; set; } = new List<Order>();
        }
    }
