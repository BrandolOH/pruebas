using HelloWorldApiv2.Models;

namespace HelloWorldApiv2.DAL.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders();
    }
}
