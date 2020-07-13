using ShoppingCartApp.DataAccessLayer.DataContext;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShoppingCartApp.DataAccessLayer.Functions
{
    public class CustomerRegistration: ICustomerRegistration
    {
        public async Task<int> RegisterUser(Customer newCustomer)//new valid customer save in the database
        {
            
            
            using (var context = new DatabaseContext())
            {
                await context.Customers.AddAsync(newCustomer);
                await context.SaveChangesAsync();
            }

            return newCustomer.CustomerId;
        }
        public List<Customer> GetAllCustomer()// access all customers 
        {
            List<Customer> customers = new List<Customer>();
            using (var context = new DatabaseContext())
            {
                customers =  context.Customers.ToList();
            }
            return customers;
        }
    }
}
