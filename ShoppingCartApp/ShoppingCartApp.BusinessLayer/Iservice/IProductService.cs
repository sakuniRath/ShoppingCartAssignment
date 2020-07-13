using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetAllProductList();
    }
}
