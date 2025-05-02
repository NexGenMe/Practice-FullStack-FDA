using Microsoft.AspNetCore.Mvc;

namespace RestaurantService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRestaurants()
        {
            // Mock restaurant data
            var restaurants = new[]
            {
                new { Id = 1, Name = "Pizza Palace", Cuisine = "Italian", Rating = 4.5 },
                new { Id = 2, Name = "Sushi World", Cuisine = "Japanese", Rating = 4.8 }
            };

            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurantDetails(int id)
        {
            // Mock restaurant details
            var restaurant = new { Id = id, Name = "Pizza Palace", Cuisine = "Italian", Rating = 4.5, Reviews = new[] { "Great food!", "Excellent service!" } };

            return Ok(restaurant);
        }

        [HttpPost("review/{id}")]
        public IActionResult AddReview(int id, [FromBody] ReviewRequest request)
        {
            // Mock logic to add a review
            return Ok(new { Message = "Review added successfully" });
        }
    }

    public class ReviewRequest
    {
        public string Review { get; set; }
        public int Rating { get; set; }
    }
}