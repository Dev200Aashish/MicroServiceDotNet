 
using Microsoft.AspNetCore.Mvc;
using ProductService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private IProductService _iProductService;
        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }
        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult Index()
        {
            try
            {
                // This branch is used to test code
                // This comment from other dev team
                return Ok(_iProductService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
