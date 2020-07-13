using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartApp.DataAccessLayer.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category{get;set;}

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
