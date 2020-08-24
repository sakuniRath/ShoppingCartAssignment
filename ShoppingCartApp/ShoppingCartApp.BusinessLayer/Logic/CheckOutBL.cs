using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.DataAccessLayer.Functions;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ShoppingCartApp.BusinessLayer.Logic
{
    public class CheckOutBL
    {
        

        private IProductList plList = new ProductListFunction();
        
        public async Task<string> CheckAvalability(CheckoutModel[] ckModel)
        {
            string message = "";
            IEnumerable<Product> pdModel = plList.GetAllProductList();
            foreach (var cmodel in ckModel)
            {
                int stockCount = pdModel.Where(x => x.ProductId == cmodel.ProductId).FirstOrDefault().Stock;
                if (stockCount < cmodel.SelectedItemCount)
                {
                    if (message == "")
                    {
                        message = cmodel.ProductName + " is Out of stock";
                    }
                    else
                    {
                        message +=" "+ cmodel.ProductName + " is Out of stock";
                    }
                }
            }

            return message;

        }

    }
}
