using HelloWorldApiv2.DTO.Interfaces;

namespace HelloWorldApiv2.BLL.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<IOrderWithUserNameDto> GetOrdersWithUserName();
    }
}
