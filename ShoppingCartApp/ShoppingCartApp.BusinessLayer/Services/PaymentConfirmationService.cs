using ShoppingCartApp.BusinessLayer.Logic;
using ShoppingCartApp.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.BusinessLayer.Services
{
    public class PaymentConfirmationService
    {
        private PaymentConfirmationBL paymentBL = new PaymentConfirmationBL();

        public async Task<bool> PaymentDetailConfirmation(PayementConfirmationModel paymentModel)
        {
            bool status = await paymentBL.PaymentDetailConfirmation(paymentModel);

            return status;
        }
    }
}
