using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Iservice
{
    public interface IUserServicecs
    {
        public Task<AuthenticateResponse> userLogin(AuthenticateRequest model);
    }
}
