using HelloWorldApiv2.Enum;

namespace HelloWorldApiv2.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }

}
