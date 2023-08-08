using eshop.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("{name}")]
        public IActionResult Search(string name)
        {

            var filteredProducts = productService.SearchProductsByName(name);
            return Ok(filteredProducts);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return Ok();
        }
    }
}
