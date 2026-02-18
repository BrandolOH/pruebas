using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.DTO.Interfaces;
using HelloWorldApiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.DAL
{
    public class OrderRepository(IDbContextFactory<AppDbContext> contextFactory) : IOrderRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory = contextFactory;

        public IQueryable<IOrderWithUserNameDto> GetOrdersWithUserName()
        {
            var context = contextFactory.CreateDbContext();

            return context.Orders
                .AsNoTracking()
                .Select(order => new OrderWithUserNameDto
                {
                    Id = order.Id,
                    CreatedAt = order.CreatedAt,
                    TotalAmount = order.TotalAmount,
                    Status = order.Status.ToString(),
                    UserName = order.User.Name
                });
        }
    }
}
