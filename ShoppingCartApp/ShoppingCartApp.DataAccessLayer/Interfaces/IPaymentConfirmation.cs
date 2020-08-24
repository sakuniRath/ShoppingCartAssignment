using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.DataAccessLayer.Interfaces
{
    public interface IPaymentConfirmation
    {
        public Task<int> PaymentConfirmationDetail();
    }
}
