﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.DataAccessLayer.Models;

namespace ShoppingCartApp.DataAccessLayer.Interfaces
{
    public interface IProductList
    {
        public IEnumerable<Product> GetAllProductList();
        
    }
}