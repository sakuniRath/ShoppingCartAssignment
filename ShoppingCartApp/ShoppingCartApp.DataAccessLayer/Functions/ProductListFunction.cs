using ShoppingCartApp.DataAccessLayer.DataContext;
using ShoppingCartApp.DataAccessLayer.Models;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShoppingCartApp.DataAccessLayer.Functions
{
    public class ProductListFunction : IProductList
    {
        public IEnumerable<Product> GetAllProductList()// get all product detail in the database
        {
            List<Product> products = new List<Product>();
            using (var context = new DatabaseContext())
            {
                products = context.Products.ToList();
            }
            return products;
        }

        
    }
}
