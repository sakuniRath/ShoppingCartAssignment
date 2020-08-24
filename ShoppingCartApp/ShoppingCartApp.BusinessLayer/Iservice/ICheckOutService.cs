using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Iservice
{
    public interface ICheckOutService
    {
        public Task<string> stockAvalibility(CheckoutModel[] checkoutModel);
    }
}
