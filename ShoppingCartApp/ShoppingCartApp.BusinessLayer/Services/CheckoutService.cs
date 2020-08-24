using ShoppingCartApp.BusinessLayer.Iservice;
using ShoppingCartApp.BusinessLayer.Logic;
using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public class CheckoutService: ICheckOutService
    {
        private CheckOutBL checkOutBL = new CheckOutBL();

        public async Task<string> stockAvalibility(CheckoutModel[] checkoutModel)
        {
            string status = await checkOutBL.CheckAvalability(checkoutModel);

            return status;
        }
    }
}
