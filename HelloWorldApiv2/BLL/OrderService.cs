using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.Models;
using System.Linq.Expressions;

namespace HelloWorldApiv2.BLL
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {
        private readonly IOrderRepository orderRepository = orderRepository;

        public IQueryable<OrderWithUserNameDto> GetOrdersWithUserName()
        {
            return orderRepository
                .GetOrders()
                .Select(MapToOrderWithUserNameDto);
        }

        private static readonly Expression<Func<Order, OrderWithUserNameDto>>
           MapToOrderWithUserNameDto = order => new OrderWithUserNameDto
           {
               Id = order.Id,
               CreatedAt = order.CreatedAt,
               TotalAmount = order.TotalAmount,
               Status = order.Status.ToString(),
               UserName = order.User.Name
           };
    }
}
