using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class ProductTests
    {
        Product _product;
        string _name;
        string _description;
        int _price;
        int _stockQuantity;
        string _imagePath;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _name = "GTX960";
            _description = "Good Performance";
            _price = 999;
            _stockQuantity = 10;
            _imagePath = "//vga.jpg";
            _product = new Product(_name, _description, _price, _stockQuantity, _imagePath);
        }

        //名稱測試
        [TestMethod()]
        public void NameTest()
        {
            _product = new Product("GTX960", "", 0, 0, "");
            var expected = "GTX960";
            Assert.AreEqual(expected, _product.Name);
            _product.Name = "GTX1080";
            expected = "GTX1080";
            Assert.AreEqual(expected, _product.Name);
        }

        //說明測試
        [TestMethod()]
        public void DescriptionTest()
        {
            _product = new Product("", "Good", 0, 0, "");
            var expected = "Good";
            Assert.AreEqual(expected, _product.Description);
            _product.Description = "Bad";
            expected = "Bad";
            Assert.AreEqual(expected, _product.Description);
        }

        //價格測試
        [TestMethod()]
        public void PriceTest()
        {
            _product = new Product("", "", 999, 0, "");
            var expected = 999;
            Assert.AreEqual(expected, _product.Price);
            _product.Price = 888;
            expected = 888;
            Assert.AreEqual(expected, _product.Price);
        }

        //數量測試
        [TestMethod()]
        public void StockQuantityTest()
        {
            _product = new Product("", "", 0, 10, "");
            var expected = 10;
            Assert.AreEqual(expected, _product.StockQuantity);
            _product.StockQuantity = 20;
            expected = 20;
            Assert.AreEqual(expected, _product.StockQuantity);
        }

        //圖片路徑測試
        [TestMethod()]
        public void ImagePathTest()
        {
            _product = new Product("", "", 0, 0, "//vga1.jpg");
            var expected = "//vga1.jpg";
            Assert.AreEqual(expected, _product.ImagePath);
            _product.ImagePath = "//vga2.jpg";
            expected = "//vga2.jpg";
            Assert.AreEqual(expected, _product.ImagePath);
        }
    }
}