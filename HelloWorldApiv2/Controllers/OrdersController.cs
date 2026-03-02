using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController(IOrderService orderService) : ControllerBase
    {
        private readonly IOrderService OrderService = orderService;

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OrderWithUserNameDto>> GetOrders()
        {
            return Ok(OrderService.GetOrdersWithUserName());
        }

    }
}
