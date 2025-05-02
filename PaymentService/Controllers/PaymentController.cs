using Microsoft.AspNetCore.Mvc;

namespace PaymentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult ProcessPayment([FromBody] PaymentRequest request)
        {
            // Mock logic to process payment
            return Ok(new { Message = "Payment processed successfully", TransactionId = "TXN12345" });
        }

        [HttpGet("{id}")]
        public IActionResult GetPaymentStatus(string id)
        {
            // Mock payment status
            var status = new { TransactionId = id, Status = "Success" };

            return Ok(status);
        }
    }

    public class PaymentRequest
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public double Amount { get; set; }
    }
}