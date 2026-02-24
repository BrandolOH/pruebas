using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

     
        [HttpGet]
        [EnableQuery]
        public IQueryable<OrderWithUserNameDto> GetOrders()
        {
            return orderService.GetOrdersWithUserName();
        }

    }
}
