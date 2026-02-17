using HelloWorldApiv2.DTO.Interfaces;

namespace HelloWorldApiv2.DTO
{
    public class OrderWithUserNameDto : IOrderWithUserNameDto
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;
    }
}
