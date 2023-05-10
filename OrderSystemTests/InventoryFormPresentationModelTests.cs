using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class InventoryFormPresentationModelTests
    {
        InventoryFormPresentationModel _presentationModel;
        Model _model;
        Stock _stock;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
            _presentationModel = new InventoryFormPresentationModel(_model, _stock);
        }

        //回傳說明測試
        [TestMethod()]
        public void ProductDescriptionTest()
        {
            _stock.SetProductDescription(0, 0, "best");
            _presentationModel.SetProductDescription(0, 0);
            Assert.AreEqual("best", _presentationModel.ProductDescription);
        }

        //設定說明測試
        [TestMethod()]
        public void SetProductDescriptionTest()
        {
            _stock.SetProductDescription(0, 0, "so good");
            _presentationModel.SetProductDescription(0, 0);
            var expected = "so good";
            Assert.AreEqual(expected, _presentationModel.ProductDescription);
        }
    }
}