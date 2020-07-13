using ShoppingCartApp.DataAccessLayer.DataContext;
using ShoppingCartApp.DataAccessLayer.Models;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartApp.DataAccessLayer.Functions
{
    public class ProductListFunction : IProductList
    {
        public async Task<List<Product>> GetAllProductList()// get all product detail in the database
        {
            List<Product> products = new List<Product>();
            using (var context = new DatabaseContext())
            {
                products = await context.Products.ToListAsync();
            }
            return products;
        }
    }
}
