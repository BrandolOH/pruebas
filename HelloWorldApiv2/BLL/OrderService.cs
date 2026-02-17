using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.DTO.Interfaces;

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
            return orderRepository.GetOrdersWithUserName().ToList();
        }
    }
}
