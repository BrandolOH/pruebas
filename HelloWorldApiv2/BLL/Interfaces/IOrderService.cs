using HelloWorldApiv2.DTO;

namespace HelloWorldApiv2.BLL.Interfaces
{
    public interface IOrderService
    {
        IQueryable<OrderWithUserNameDto> GetOrdersWithUserName();
    }
}
