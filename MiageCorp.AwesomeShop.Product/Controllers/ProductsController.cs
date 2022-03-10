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
        public Produit Get(int productId)
        {
            return ProductService.getProductById(productId);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Produit product)
        {
            ProductService.addProduct(product);

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produit produit)
        {
            ProductService.updateProduct(id, produit);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProductService.deleteProduct(id);
        }
    }
}
