using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult Search(string name)
        {
            return Ok(new { message = "This is for success...." });
        }
    }
}
