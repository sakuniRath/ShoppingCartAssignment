using ShoppingCartApp.DataAccessLayer.DataContext;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartApp.DataAccessLayer.Functions
{
    public class UserDetail:IUser
    {
        public IEnumerable<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (var context = new DatabaseContext())
            {
                customers = context.Customers.ToList();
            }
            return customers;
        }
    }
}
