using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class StockTests
    {
        Stock _stock;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
        }

        [TestMethod()]
        public void GetProductNameTest()
        {
            Stock stock = new Stock();
            Assert.AreEqual("ASUS Z87-DELUX", stock.GetProductName(0, 0));
        }

        [TestMethod()]
        public void GetProductDescriptionTest()
        {
            Assert.AreEqual("適用於第四代 haswell intel處理器 ★使用 intel b85 晶片組 ★pcie 3.0 傳輸速度加快 ★epu省電引擎 能降低風扇噪音", _stock.GetProductDescription(0, 0));
        }

        [TestMethod()]
        public void GetProductPriceTest()
        {
            Assert.AreEqual(1380, _stock.GetProductPrice(0, 0));
        }

        [TestMethod()]
        public void GetProductStockQuantityTest()
        {
            Assert.AreEqual(10, _stock.GetProductStockQuantity(0, 0));
        }

        [TestMethod()]
        public void GetProductImagePathTest()
        {
            Assert.AreEqual("MB01.jpg", _stock.GetProductImagePath(0, 0));
        }

        [TestMethod()]
        public void GetCategoryCountTest()
        {
            Assert.AreEqual(6, _stock.GetCategoryCount());
        }

        [TestMethod()]
        public void GetProductCountTest()
        {
            Assert.AreEqual(9, _stock.GetProductCount(0));
            Assert.AreEqual(9, _stock.GetProductCount(5));
        }

        [TestMethod()]
        public void ProductListTest()
        {
            BindingList<Category> list = new BindingList<Category>();
            list = _stock.ProductList;
            Assert.AreEqual(list, _stock.ProductList);
        }

        [TestMethod()]
        public void GetProductCategoryNameTest()
        {
            Assert.AreEqual("CPU", _stock.GetProductCategoryName(1));
        }

        [TestMethod()]
        public void SetProductNameTest()
        {
            _stock.SetProductName(0, 0, "New");
            Assert.AreEqual("New", _stock.GetProductName(0, 0));
        }

        [TestMethod()]
        public void SetProductDescriptionTest()
        {
            _stock.SetProductDescription(0, 0, "Test");
            Assert.AreEqual("Test", _stock.GetProductDescription(0, 0));
        }

        [TestMethod()]
        public void SetProductPriceTest()
        {
            _stock.SetProductPrice(0, 0, 100);
            Assert.AreEqual(100, _stock.GetProductPrice(0, 0));
        }

        [TestMethod()]
        public void SetProductImagePathTest()
        {
            _stock.SetProductImagePath(0, 0, "test.png");
            Assert.AreEqual("test.png", _stock.GetProductImagePath(0, 0));
        }

        [TestMethod()]
        public void SetProductCategoryTest()
        {
            _stock.SetProductCategory(0, "NewCategory");
            Assert.AreEqual("NewCategory", _stock.GetProductCategoryName(0));
        }

        [TestMethod()]
        public void SupplyProductTest()
        {
            _stock.SupplyProduct(0, 0, 100);
            Assert.AreEqual(100, _stock.GetProductStockQuantity(0, 0));
        }

        [TestMethod()]
        public void AddNewProductTest()
        {
            List<string> list = new List<string>() { "", "", "0", "0" };
            _stock.AddNewProduct(0, list, 0);
            Assert.AreEqual(10, _stock.GetProductCount(0));
        }

        [TestMethod()]
        public void RemoveProductTest()
        {
            _stock.RemoveProduct(0, 0);
            Assert.AreEqual(8, _stock.GetProductCount(0));
        }

        [TestMethod()]
        public void AddNewCategoryTest()
        {
            _stock.AddNewCategory("Test");
            Assert.AreEqual(7, _stock.GetCategoryCount());
        }
    }
}