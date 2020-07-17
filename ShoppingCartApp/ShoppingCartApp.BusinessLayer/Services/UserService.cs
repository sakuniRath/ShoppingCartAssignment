using Microsoft.IdentityModel.Tokens;
using ShoppingCartApp.BusinessLayer.Iservice;
using ShoppingCartApp.BusinessLayer.Logic;
using ShoppingCartApp.BusinessLayer.Models;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public class UserService: IUserServicecs
    {
        private UserBL pbl = new UserBL();

        public async Task<AuthenticateResponse> userLogin(AuthenticateRequest model)
        {
            AuthenticateResponse status = pbl.Authenticate(model);

            return status;
        }


    }
}
