using Microsoft.AspNetCore.Mvc;

namespace DeliveryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetDeliveryStatus(int id)
        {
            // Mock delivery status
            var status = new { OrderId = id, Status = "Out for Delivery", ETA = "30 minutes" };

            return Ok(status);
        }

        [HttpPost]
        public IActionResult AssignDeliveryAgent([FromBody] DeliveryRequest request)
        {
            // Mock logic to assign a delivery agent
            return Ok(new { Message = "Delivery agent assigned successfully", AgentId = 101 });
        }
    }

    public class DeliveryRequest
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
    }
}