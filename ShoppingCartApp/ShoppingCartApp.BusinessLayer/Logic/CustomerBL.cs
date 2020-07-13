using Microsoft.VisualBasic;
using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.DataAccessLayer.Functions;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Logic
{
    public class CustomerBL
    {
        private ICustomerRegistration customer = new CustomerRegistration();

        

        public async Task<bool> CreateNewUser(CustomerModel customerModel)//customer map to cutomer model
        {
            try
            {
                List<Customer> cusObj = customer.GetAllCustomer();
                Customer selectedCustomer=cusObj.Where(x=>x.Email== customerModel.Email).FirstOrDefault(); //validation check duplication of email address

                if (selectedCustomer == null)
                {
                    Customer newCustomer = new Customer
                    {
                        FirstName = customerModel.FirstName,
                        LastName = customerModel.LastName,
                        CreatedDate = DateTime.Now,
                        PhoneNumber = customerModel.PhoneNumber,
                        Email = customerModel.Email,
                        Password = customerModel.Password,
                        Address = customerModel.Address
                    };
                    var result = await customer.RegisterUser(newCustomer);

                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}
