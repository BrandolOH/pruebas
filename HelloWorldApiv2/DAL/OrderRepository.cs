using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.DAL
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public OrderRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public IQueryable<Order> GetOrders()
        {
            var context = contextFactory.CreateDbContext();

            return context.Orders
                .AsNoTracking()
                .Include(order => order.User);
        }
    }
}
