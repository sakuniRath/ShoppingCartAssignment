using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.BusinessLayer.Services;


namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //Customer Controller
        private readonly ICustomerService serviceC; //business layer refrence
        public CustomerController(ICustomerService service)
        {
            serviceC = service;
        }
        
        [HttpPost]
        public async Task<bool> PostRegisterCustomer(CustomerModel customerMoedel)//Customer registration function
        {

            bool status = await serviceC.CreateNewUser(customerMoedel);
            return status;
        }
    }
   
}
