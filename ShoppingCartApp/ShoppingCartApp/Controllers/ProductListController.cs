using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer;
using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.BusinessLayer.Services;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListController : ControllerBase
    {
        //Product contoller
        
        private readonly IProductService _service;//business layer reference 

        public ProductListController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductList()// retrieve all availabale product in database
        {
            List<ProductModel> products = await _service.GetAllProductList();
            return Ok(products);
        }
        
    }
}
