using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartApp.BusinessLayer.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(Customer user, string token)
        {
            Id = user.CustomerId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Email;
            Token = token;
        }
    }
}
