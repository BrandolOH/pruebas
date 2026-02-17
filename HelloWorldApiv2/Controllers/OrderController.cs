using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        // GET api/orders
        [HttpGet]
        public ActionResult<IEnumerable<IOrderWithUserNameDto>> GetOrders()
        {
            var orders = orderService.GetOrdersWithUserName();
            return Ok(orders);
        }

    }
}
