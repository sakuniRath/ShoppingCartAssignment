using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer.Iservice;
using ShoppingCartApp.BusinessLayer.Models;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentConfirmationController : ControllerBase
    {
        readonly private IPaymentConfirmationService serviceP;

        public PaymentConfirmationController(IPaymentConfirmationService service)
        {
            serviceP = service;
        }

        [HttpPost]

        public async Task<IActionResult> PaymentDetailsConfirmation(PayementConfirmationModel payemtModel)//
        {

            bool status = await serviceP.PaymentDetailsConfirmation(payemtModel);
            if (status != null)
                return BadRequest(new { message = status });
            return Ok(status);
        }

    }
}
