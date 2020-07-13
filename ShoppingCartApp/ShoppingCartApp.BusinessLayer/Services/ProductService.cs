using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public class ProductService: IProductService
    {
        private ProductBL pbl = new ProductBL();
        public async Task<List<ProductModel>> GetAllProductList()
        {

            List<ProductModel> products = await pbl.GetAllProductList();
            return products;
        }
    }
}
