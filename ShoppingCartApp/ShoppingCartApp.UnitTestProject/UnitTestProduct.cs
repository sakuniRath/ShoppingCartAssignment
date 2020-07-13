using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp.BusinessLayer.Services;
using Moq;
using ShoppingCartApp.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using ShoppingCartApp.BusinessLayer.Models;
using System.Collections.Generic;

namespace ShoppingCartApp.UnitTestProject
{
    [TestClass]
    public class UnitTestProduct
    {
        [TestMethod]
        public void TestProductList()
        {
            var mock = new Mock<IProductService>();
            List<ProductModel> ob = new List<ProductModel>();
            ob.Add(new ProductModel()
            {
                ProductId = 1,
                ProductName = "Yellow saree",
                Stock = 100,
                UnitPrice = 5000,
                Image = "/Images/saree1.jpg"
            });
            //mock.Setup(p => p.GetAllProductList()).Returns(ob);
            ProductListController pl = new ProductListController(mock.Object);
            Task<IActionResult> result = pl.GetProductList();
            Assert.AreEqual(ob, result);
            
            
          
        }
    }
}
