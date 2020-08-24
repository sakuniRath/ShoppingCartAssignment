using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Iservice
{
   public interface IPaymentConfirmationService
    {
        public Task<bool> PaymentDetailsConfirmation(PayementConfirmationModel paymentModel);
    }
}
