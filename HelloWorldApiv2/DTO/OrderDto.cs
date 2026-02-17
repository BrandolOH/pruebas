using HelloWorldApiv2.DTO.Interfaces;

namespace HelloWorldApiv2.DTO
{
    public class OrderDto : IOrderDto
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}
