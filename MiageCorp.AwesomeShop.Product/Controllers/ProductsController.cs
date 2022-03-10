using MiageCorp.AwesomeShop.Product.Models;
using MiageCorp.AwesomeShop.Product.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiageCorp.AwesomeShop.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       
        private IProductService ProductService { get; set; }

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }


        // GET: api/<ProductsController>
        [HttpGet("")]
        public List<Produit> Get()
        {
            return ProductService.getAllProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{productId}")]
        public IActionResult Get(string productId)
        {
            var product = ProductService.getProductById(productId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Produit product)
        {
            ProductService.addProduct(product);
            return Ok();

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Produit produit)
        {
            try
            {
                ProductService.updateProduct(id, produit);
                return Ok();
            }
            catch (Exception)
            {  
                return NotFound();
            }
            
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
         ProductService.deleteProduct(id);
                return NoContent();
        }
    }
}
