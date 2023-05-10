using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order _order = new Order("New", "CPU", 100, 5);

        [TestMethod()]
        public void GetProductNameTest()
        {
            _order = new Order("New", "", 0, 0);
            Assert.AreEqual("New", _order.GetProductName());
        }

        [TestMethod()]
        public void GetProductCategoryTest()
        {
            _order = new Order("", "CPU", 99, 10);
            Assert.AreEqual("CPU", _order.GetProductCategory());
        }

        [TestMethod()]
        public void GetProductPriceTest()
        {
            _order = new Order("", "", 999, 0);
            Assert.AreEqual(999, _order.GetProductPrice());
        }

        [TestMethod()]
        public void GetProductQuantityTest()
        {
            _order = new Order("", "", 0, 50);
            Assert.AreEqual(50, _order.GetProductQuantity());
        }

        [TestMethod()]
        public void SetProductQuantityTest()
        {
            _order.SetProductQuantity(50);
        }

        [TestMethod()]
        public void SetProductNameTest()
        {
            _order.SetProductName("Old");
        }

        [TestMethod()]
        public void SetProductPriceTest()
        {
            _order.SetProductPrice(1000);
        }

        [TestMethod()]
        public void SetProductCategoryTest()
        {
            _order.SetProductCategory("RAM");
        }
    }
}