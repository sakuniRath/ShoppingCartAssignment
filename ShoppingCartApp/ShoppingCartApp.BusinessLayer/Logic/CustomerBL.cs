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

        
        /// <summary>
        /// Map customer model to sql customer model and inside the function password encrption happend by uisng hash
        /// </summary>
        /// <param name="customerModel"></param>
        /// <returns></returns>
        public async Task<bool> CreateNewUser(CustomerModel customerModel)//customer map to cutomer model
        {
            try
            {
                List<Customer> cusObj = customer.GetAllCustomer();
                Customer selectedCustomer=cusObj.Where(x=>x.Email== customerModel.Email).FirstOrDefault(); //validation check duplication of email address

                if (selectedCustomer == null && customerModel.Password != null)
                {
                    byte[] passToHash;
                    string encryptedPassword="";
                   
                   passToHash = System.Text.Encoding.UTF8.GetBytes(customerModel.Password);// string password convert to byte array
                   encryptedPassword=Shared.shared.Hash(passToHash);// call passwrod encryption menthod
                   
                    Customer newCustomer = new Customer
                    {
                        FirstName = customerModel.FirstName,
                        LastName = customerModel.LastName,
                        CreatedDate = DateTime.Now,
                        PhoneNumber = customerModel.PhoneNumber,
                        Email = customerModel.Email,
                        Password = encryptedPassword,
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
