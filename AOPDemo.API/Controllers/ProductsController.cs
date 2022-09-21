using AOPDemo.Core.Interface.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AOPDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductsController(IProduct product)
        {
            _product = product;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            //Thread.Sleep(1000);
            var result = _product.GetAll();

            return Ok(result);
        }
    }
}
