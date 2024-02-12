using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrate.EntityFrameWork;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ProductsController : Controller
    {
        //Loosly Coupled
        //IoC Container
        IProductService _productService;
        public ProductsController(IProductService productservice)
        {
            _productService = productservice;
        }
        [Route("api/[controller]")]
       
       /* public IActionResult Index()
        {
            return View();
        }*/
       
        [HttpGet]
        public List<Product> Get()
        {
            IProductService proservice = new ProductManager(new EfProductDal());
            return proservice.GetAll().Data;
           
        }
    }
}
