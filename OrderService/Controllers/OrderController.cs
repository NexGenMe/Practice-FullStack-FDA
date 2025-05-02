using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetOrderDetails(int id)
        {
            // Mock order details
            var order = new { Id = id, Items = new[] { "Pizza", "Salad" }, Total = 14.98, Status = "Processing" };

            return Ok(order);
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] OrderRequest request)
        {
            // Mock logic to place an order
            return Ok(new { Message = "Order placed successfully", OrderId = 123 });
        }

        [HttpPut("{id}/status")]
        public IActionResult UpdateOrderStatus(int id, [FromBody] OrderStatusRequest request)
        {
            // Mock logic to update order status
            return Ok(new { Message = "Order status updated successfully" });
        }
    }

    public class OrderRequest
    {
        public string[] Items { get; set; }
        public double Total { get; set; }
    }

    public class OrderStatusRequest
    {
        public string Status { get; set; }
    }
}