using HelloWorldApiv2.DTO.Interfaces;

namespace HelloWorldApiv2.DAL.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<IOrderWithUserNameDto> GetOrdersWithUserName();
    }
}
