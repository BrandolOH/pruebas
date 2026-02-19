using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.DAL
{
    public class OrderRepository(IDbContextFactory<AppDbContext> contextFactory) : IOrderRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory = contextFactory;

        public IQueryable<Order> GetOrders()
        {
            var context = contextFactory.CreateDbContext();

            return context.Orders
                .AsNoTracking()
                .Include(order => order.User);
        }
    }
}
