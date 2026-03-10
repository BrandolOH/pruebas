using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.DAL
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Order> GetOrders()
        {
            return _context.Orders
                .AsNoTracking()
                .Include(order => order.User);
        }
    }
}