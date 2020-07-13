using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.DataAccessLayer.Interfaces
{
    public interface ICustomerRegistration
    {
        public Task<int> RegisterUser(Customer newCustomer);
        public List<Customer> GetAllCustomer();
    }
}
