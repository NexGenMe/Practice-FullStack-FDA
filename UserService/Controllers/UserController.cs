using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUserProfile(int id)
        {
            // Mock user profile data
            var userProfile = new
            {
                Id = id,
                Name = "John Doe",
                Email = "johndoe@example.com",
                Address = "123 Main St, City, Country"
            };

            return Ok(userProfile);
        }

        [HttpPost]
        public IActionResult CreateUserProfile([FromBody] UserProfileRequest request)
        {
            // Mock logic to create a user profile
            return Ok(new { Message = "User profile created successfully" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserProfile(int id, [FromBody] UserProfileRequest request)
        {
            // Mock logic to update a user profile
            return Ok(new { Message = "User profile updated successfully" });
        }
    }

    public class UserProfileRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}