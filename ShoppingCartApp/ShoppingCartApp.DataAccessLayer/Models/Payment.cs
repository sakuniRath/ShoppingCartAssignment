using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartApp.DataAccessLayer.Models
{
    public class Payment
    {
        
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Orders { get; set; }
       

    }
}
