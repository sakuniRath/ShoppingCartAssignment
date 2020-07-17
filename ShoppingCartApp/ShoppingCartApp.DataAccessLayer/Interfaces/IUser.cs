using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartApp.DataAccessLayer.Interfaces
{
    public interface IUser
    {
        public IEnumerable<Customer> GetAll();
    }
}
