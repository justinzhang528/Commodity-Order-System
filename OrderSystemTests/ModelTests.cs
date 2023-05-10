using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class ModelTests
    {
        Model _model;
        Stock _stock;
        Category _category;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
        }

        [TestMethod()]
        public void GetProductImagePathTest()
        {
            Assert.AreEqual("MB01.jpg", _model.GetProductImagePath(0, 0));
            Assert.AreEqual("comset09.jpg", _model.GetProductImagePath(5, 8));

        }

        [TestMethod()]
        public void GetProductNameTest()
        {
            Assert.AreEqual("ASUS Z87-DELUX", _model.GetProductName(0, 0));
            Assert.AreEqual("Intel NUC8i7BEH-0824N", _model.GetProductName(5, 7));
        }

        [TestMethod()]
        public void GetProductDescriptionTest()
        {
            List<string> list = new List<string> { "I9", "Best", "1000", "//cpu1.jpg" };
            _stock.AddNewCategory("CPU");
            _stock.AddNewProduct(6, list, 1);
            Assert.AreEqual("Best", _model.GetProductDescription(6, 0));
        }

        [TestMethod()]
        public void GetProductStockQuantityTest()
        {
            Assert.AreEqual(10, _model.GetProductStockQuantity(0, 0));
            Assert.AreEqual(8, _model.GetProductStockQuantity(5, 8));
        }

        [TestMethod()]
        public void GetProductPriceTest()
        {
            Assert.AreEqual(1380, _model.GetProductPrice(0, 0));
            Assert.AreEqual(50390, _model.GetProductPrice(5, 8));
        }

        [TestMethod()]
        public void GetProductTotalPriceTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 10, 10), 100);
            Assert.AreEqual(100, _model.GetProductTotalPrice(0));
        }

        [TestMethod()]
        public void SetProductTotalPriceTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 10, 10), 100);
            _model.SetProductTotalPrice(0, 666);
            Assert.AreEqual(666, _model.GetProductTotalPrice(0));
        }

        [TestMethod()]
        public void SetOrderProductQuantityTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 10, 10), 100);
            _model.SetOrderProductQuantity(0, 9);
        }

        [TestMethod()]
        public void SetOrderProductNameTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 20, 5), 100);
            _model.SetOrderProductName(0, "test");
        }

        [TestMethod()]
        public void SetOrderProductCategoryTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 20, 5), 100);
            _model.SetOrderProductCategory(0, "test");
        }

        [TestMethod()]
        public void SetOrderProductPriceTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 50, 2), 100);
            _model.SetOrderProductPrice(0, 100);
        }

        [TestMethod()]
        public void GetOrderProductQuantityTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 50, 2), 100);
            Assert.AreEqual(2, _model.GetOrderProductQuantity(0));
        }

        [TestMethod()]
        public void GetCategoryCountTest()
        {
            Assert.AreEqual(6, _model.GetCategoryCount());
            _stock.AddNewCategory("");
            Assert.AreEqual(7, _model.GetCategoryCount());
        }

        [TestMethod()]
        public void GetProductCountTest()
        {
            _stock.AddNewCategory("");
            Assert.AreEqual(9, _model.GetProductCount(0));
            Assert.AreEqual(0, _model.GetProductCount(6));
        }

        [TestMethod()]
        public void GetProductCategoryNameTest()
        {
            _stock.AddNewCategory("New");
            Assert.AreEqual("New", _model.GetProductCategoryName(6));
        }

        [TestMethod()]
        public void RemoveOrderInfoFromListTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 50, 2), 100);
            _model.AddOrderInfoToList(new Order("", "", 40, 3), 120);
            Assert.AreEqual(2, _model.GetOrderCount());
            _model.RemoveOrderInfoFromList(0);
            Assert.AreEqual(1, _model.GetOrderCount());
        }

        [TestMethod()]
        public void ClearOrderInfoTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 50, 2), 100);
            _model.AddOrderInfoToList(new Order("", "", 40, 3), 120);
            Assert.AreEqual(2, _model.GetOrderCount());
            _model.ClearOrderInfo();
            Assert.AreEqual(0, _model.GetOrderCount());
        }

        [TestMethod()]
        public void GetOrderTotalPriceTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 500, 2), 1000);
            _model.AddOrderInfoToList(new Order("", "", 400, 3), 1200);
            Assert.AreEqual(2200, _model.GetOrderTotalPrice());
        }

        [TestMethod()]
        public void GetOrderTotalPriceStringTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 300, 2), 600);
            Assert.AreEqual("600", _model.GetOrderTotalPriceString());
            _model.ClearOrderInfo();
            _model.AddOrderInfoToList(new Order("", "", 0, 0), 0);
            Assert.AreEqual("0", _model.GetOrderTotalPriceString());
        }

        [TestMethod()]
        public void GetOrderProductNameTest()
        {
            _model.AddOrderInfoToList(new Order("New", "", 300, 2), 600);
            Assert.AreEqual("New", _model.GetOrderProductName(0));
        }

        [TestMethod()]
        public void GetOrderProductPriceTest()
        {
            _model.AddOrderInfoToList(new Order("", "", 300, 2), 600);
            Assert.AreEqual("300", _model.GetOrderProductPrice(0));
        }

        [TestMethod()]
        public void GetOrderProductCategoryTest()
        {
            _model.AddOrderInfoToList(new Order("New", "RAM", 300, 2), 600);
            Assert.AreEqual("RAM", _model.GetOrderProductCategory(0));
        }

        [TestMethod()]
        public void IsNumericTest()
        {
            Assert.AreEqual(true, _model.IsNumeric("300"));
            Assert.AreEqual(false, _model.IsNumeric("test"));
        }

        [TestMethod()]
        public void IsValidMailFormatTest()
        {
            Assert.AreEqual(true, _model.IsValidMailFormat("test@gmail.com"));
            Assert.AreEqual(false, _model.IsValidMailFormat("www.test.com"));
        }

        [TestMethod()]
        public void IsValidNameTest()
        {
            Assert.AreEqual(true, _model.IsValidName("justin"));
            Assert.AreEqual(false, _model.IsValidName("123justin"));
        }

        [TestMethod()]
        public void ConvertFromIndexToProductNumberTest()
        {
            _model.ConvertFromIndexToProductNumber(20);
            Assert.AreEqual(2, _model.CategoryNumber);
            Assert.AreEqual(2, _model.ProductNumber);
            _model.CategoryNumber = 0;
            _model.ProductNumber = 5;
            Assert.AreEqual(0, _model.CategoryNumber);
            Assert.AreEqual(5, _model.ProductNumber);
        }

        [TestMethod()]
        public void SupplyProductTest()
        {
            _model.SupplyProduct(0, 0, 10);
        }

        [TestMethod()]
        public void GetOrderInputQuantityTest()
        {
            _model.SetOrderInputQuantity("10");
            Assert.AreEqual(10, _model.GetOrderInputQuantity());
        }

        [TestMethod()]
        public void GetProductStockQuantityTest1()
        {
            _model.AddOrderInfoToList(new Order("Intel Petium", "RAM", 300, 2), 600);
            _model.SetCategoryAndProductIndex(0);
            Assert.AreEqual(0, _model.GetProductStockQuantity());
        }

        [TestMethod()]
        public void GetCompareInputQuantityAndStockQuantityTest()
        {
            _model.AddOrderInfoToList(new Order("ASUS Z87-DELUX", "RAM", 300, 2), 600);
            _model.SetOrderInputQuantity("9");
            Assert.AreEqual(false, _model.GetCompareInputQuantityAndStockQuantity());
            _model.SetOrderInputQuantity("20");
            Assert.AreEqual(true, _model.GetCompareInputQuantityAndStockQuantity());
        }

        [TestMethod()]
        public void SetOrderProductQuantityAndTotalPriceTest()
        {
            _model.AddOrderInfoToList(new Order("ASUS Z87-DELUX", "RAM", 300, 2), 600);
            _model.SetOrderProductQuantityAndTotalPrice(0);
        }
    }
}