using System;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Functions;
using ShoppingCartApp.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using ShoppingCartApp.BusinessLayer.Models;

namespace ShoppingCartApp.BusinessLayer
{
    public class ProductBL
    {
        private IProductList productList = new ProductListFunction();


        public async Task<List<ProductModel>> GetAllProductList()// db product model map to prodctModel
        {
            List<ProductModel> pm = new List<ProductModel>();
            List<Product> productAllList = await productList.GetAllProductList();
            foreach (var product in productAllList)
            {
                pm.Add(new ProductModel()
                {

                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    Stock = product.Stock,
                    Image = "/Images/" + product.Image
                }) ;


            }

            return pm;
        }
    }
}
