using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        Category _category;
        string _name;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _name = "CPU";
            _category = new Category(_name);
        }

        //類別名稱測試
        [TestMethod()]
        public void CategoryNameTest()
        {
            var expected = "CPU";
            Assert.AreEqual(expected, _category.CategoryName);
            _category.CategoryName = "RAM";
            expected = "RAM";
            Assert.AreEqual(expected, _category.CategoryName);
        }

        //新增商品稱測試
        [TestMethod()]
        public void AddNewProductTest()
        {
            Product product = new Product("I9", "Best", 1999, 50, "//cpu1.jpg");
            _category.AddNewProduct(product);
        }

        //移除商品測試
        [TestMethod()]
        public void RemoveProductTest()
        {
            Product product = new Product("I7", "", 0, 0, "");
            _category.AddNewProduct(product);
            _category.AddNewProduct(product);
            _category.RemoveProduct(1);
            _category.RemoveProduct(0);
        }

        //回傳商品名稱測試
        [TestMethod()]
        public void GetProductNameTest()
        {
            Product product = new Product("I7", "", 0, 0, "");
            _category.AddNewProduct(product);
            var expectedName = "I7";
            Assert.AreEqual(expectedName, _category.GetProductName(0));
        }

        //回傳商品描述測試
        [TestMethod()]
        public void GetProductDescriptionTest()
        {
            Product product = new Product("", "Good", 0, 0, "");
            _category.AddNewProduct(product);
            var expectedDescription = "Good";
            Assert.AreEqual(expectedDescription, _category.GetProductDescription(0));
        }

        //回傳商品價格測試
        [TestMethod()]
        public void GetProductPriceTest()
        {
            Product product = new Product("", "", 2499, 0, "");
            _category.AddNewProduct(product);
            var expectedPrice = 2499;
            Assert.AreEqual(expectedPrice, _category.GetProductPrice(0));
        }

        //回傳商品數量測試
        [TestMethod()]
        public void GetProductStockQuantityTest()
        {
            Product product = new Product("", "", 0, 100, "");
            _category.AddNewProduct(product);
            var expectedQuantity = 100;
            Assert.AreEqual(expectedQuantity, _category.GetProductStockQuantity(0));
        }

        //回傳商品圖片路徑測試
        [TestMethod()]
        public void GetProductImagePathTest()
        {
            Product product = new Product("", "", 0, 0, "//small.jpg");
            _category.AddNewProduct(product);
            var expectedImagePath = "//small.jpg";
            Assert.AreEqual(expectedImagePath, _category.GetProductImagePath(0));
        }

        //設定商品名稱測試
        [TestMethod()]
        public void SetProductNameTest()
        {
            Product product = new Product("I7", "", 0, 0, "");
            _category.AddNewProduct(product);
            _category.SetProductName(0, "I5");
            var expectedName = "I5";
            Assert.AreEqual(expectedName, _category.GetProductName(0));
        }

        //設定商品描述測試
        [TestMethod()]
        public void SetProductDescriptionTest()
        {
            Product product = new Product("", "Good", 0, 0, "");
            _category.AddNewProduct(product);
            _category.SetProductDescription(0, "Not So Bad");
            var expectedDescription = "Not So Bad";
            Assert.AreEqual(expectedDescription, _category.GetProductDescription(0));
        }

        //設定商品類別測試
        [TestMethod()]
        public void SetProductCategoryTest()
        {
            _category.SetProductCategory("RAM");
        }

        //設定商品價格測試
        [TestMethod()]
        public void SetProductPriceTest()
        {
            Product product = new Product("", "", 2499, 0, "");
            _category.AddNewProduct(product);
            _category.SetProductPrice(0, 5999);
            var expectedPrice = 5999;
            Assert.AreEqual(expectedPrice, _category.GetProductPrice(0));
        }

        //設定商品數量測試
        [TestMethod()]
        public void SetProductStockQuantityTest()
        {
            Product product = new Product("", "", 0, 100, "");
            _category.AddNewProduct(product);
            _category.SetProductStockQuantity(0, 99);
            var expectedQuantity = 99;
            Assert.AreEqual(expectedQuantity, _category.GetProductStockQuantity(0));
        }

        //設定商品圖片路徑測試
        [TestMethod()]
        public void SetProductImagePathTest()
        {
            Product product = new Product("", "", 0, 0, "//small.jpg");
            _category.AddNewProduct(product);
            _category.SetProductImagePath(0, "//large.jpg");
            var expectedImagePath = "//large.jpg";
            Assert.AreEqual(expectedImagePath, _category.GetProductImagePath(0));
        }

        //設定商品數量測試
        [TestMethod()]
        public void ProductCountTest()
        {
            Assert.AreEqual(0, _category.ProductCount);
            Product product = new Product("", "", 0, 0, "");
            _category.AddNewProduct(product);
            Assert.AreEqual(1, _category.ProductCount);
            _category.AddNewProduct(product);
            _category.AddNewProduct(product);
            Assert.AreEqual(3, _category.ProductCount);
        }
    }
}