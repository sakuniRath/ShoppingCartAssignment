using ShoppingCartApp.BusinessLayer.Logic;
using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public class CustomerService : ICustomerService
    {
        private CustomerBL pbl = new CustomerBL();
        public async Task<bool> CreateNewUser(CustomerModel customerModel)
        {
            bool status = await pbl.CreateNewUser(customerModel);

            return status;
        }
    }
}
