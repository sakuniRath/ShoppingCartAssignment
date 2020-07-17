using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartApp.BusinessLayer.Models
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
