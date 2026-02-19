using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.DTO.Interfaces;
using HelloWorldApiv2.Models;

namespace HelloWorldApiv2.BLL
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<IOrderWithUserNameDto> GetOrdersWithUserName()
        {
            return orderRepository
                .GetOrders()
                .Select(MapToOrderWithUserNameDto)
                .ToList();
        }

        private static OrderWithUserNameDto MapToOrderWithUserNameDto(Order order)
        {
            return new OrderWithUserNameDto
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                TotalAmount = order.TotalAmount,
                Status = order.Status.ToString(),
                UserName = order.User.Name
            };
        }
    }
}
