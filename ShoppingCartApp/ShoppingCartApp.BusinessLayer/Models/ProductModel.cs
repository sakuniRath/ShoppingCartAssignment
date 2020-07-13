using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartApp.BusinessLayer.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Stock { get; set; }

        public decimal UnitPrice { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }
    }
}
