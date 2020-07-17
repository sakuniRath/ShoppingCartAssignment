using Microsoft.IdentityModel.Tokens;
using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.DataAccessLayer.Functions;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ShoppingCartApp.BusinessLayer.Logic
{
    public class UserBL
    {
        private IUser user = new UserDetail();
        private const string secret = "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING";
        /// <summary>
        /// User Authenticate
        /// </summary>
        /// <param name="model">AuthenticateRequest type model</param>
        /// <returns>JWT Token and user details</returns>
        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            IEnumerable<Customer> cus= user.GetAll();
            byte[] passToHash = System.Text.Encoding.UTF8.GetBytes(model.Password);// call password encrpted method
            string encryptedPassword = Shared.shared.Hash(passToHash);// get encripted password 
            var userL = cus.SingleOrDefault(x => x.Email == model.Username && x.Password == encryptedPassword);
            // return null if user not found
            if (userL == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(userL);

            return new AuthenticateResponse(userL, token);
        }

        /// <summary>
        /// Creating a JWT Token
        /// </summary>
        /// <param name="user"></param>
        /// <returns> craeted JWT Token</returns>
            private string generateJwtToken(Customer user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(user.Email,user.CustomerId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
