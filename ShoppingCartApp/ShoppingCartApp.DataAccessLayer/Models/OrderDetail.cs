using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartApp.DataAccessLayer.Models
{
    public class OrderDetail
    {
       
        public int OrderDetailId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Quntity { get; set; }
        [Required]
        public decimal  UnitPrice { get; set; }
        public virtual Product Products { get; set; }
        public virtual Order Orders { get; set; }

    }
}
