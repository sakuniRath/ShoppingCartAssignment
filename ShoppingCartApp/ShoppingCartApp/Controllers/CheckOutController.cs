using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer.Iservice;
using ShoppingCartApp.BusinessLayer.Models;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CheckOutController : ControllerBase
    {
        //Stock check Controller
        private readonly ICheckOutService serviceC; //business layer refrence

        public CheckOutController(ICheckOutService service) {
            serviceC = service;

        }

        [HttpPost]
        public async Task<IActionResult> CheckStock([FromBody] CheckoutModel[] chekoutModel)//check stock availablility registration function
        {

            string status = await serviceC.stockAvalibility(chekoutModel);
            if (status!=null)
                return BadRequest(new { message = status });
            return Ok(status);
        }
    }
}
