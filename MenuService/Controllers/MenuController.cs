using Microsoft.AspNetCore.Mvc;

namespace MenuService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMenuItems()
        {
            // Mock menu items data
            var menuItems = new[]
            {
                new { Id = 1, Name = "Margherita Pizza", Category = "Pizza", Price = 8.99 },
                new { Id = 2, Name = "Caesar Salad", Category = "Salad", Price = 5.99 }
            };

            return Ok(menuItems);
        }

        [HttpPost]
        public IActionResult AddMenuItem([FromBody] MenuItemRequest request)
        {
            // Mock logic to add a menu item
            return Ok(new { Message = "Menu item added successfully" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMenuItem(int id, [FromBody] MenuItemRequest request)
        {
            // Mock logic to update a menu item
            return Ok(new { Message = "Menu item updated successfully" });
        }
    }

    public class MenuItemRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}