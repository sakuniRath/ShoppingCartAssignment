using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ShoppingCartApp.BusinessLayer.Iservice;
using ShoppingCartApp.BusinessLayer.Models;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginUserController : ControllerBase
    {
        //Customer Controller
        private readonly IUserServicecs serviceU; //business layer refrence

        public LoginUserController(IUserServicecs service)
        {
            serviceU = service;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)// user Authentication funtion
        {
            var response = await serviceU.userLogin(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


    }
}
