using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.DataAccessLayer.Models;

namespace ShoppingCartApp.DataAccessLayer.Interfaces
{
    public interface IProductList
    {
        public Task<List<Product>> GetAllProductList();
        
    }
}