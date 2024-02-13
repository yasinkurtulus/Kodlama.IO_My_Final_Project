using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrate.EntityFrameWork;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        //Loosly Coupled
        //IoC Container
        IProductService _productService;
        public ProductsController(IProductService productservice)
        {
            _productService = productservice;
        }
       

        /* public IActionResult Index()
         {
             return View();
         }*/

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _productService.GetAll();
            if (result.Succes == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result=_productService.GetById(id);
            if (result.Succes == true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
