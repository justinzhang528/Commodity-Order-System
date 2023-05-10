using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class ProductManageFormPresentationModelTests
    {
        Model _model;
        Stock _stock;
        ProductManageFormPresentationModel _presentationModel;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
            _presentationModel = new ProductManageFormPresentationModel(_model, _stock);
        }

        [TestMethod()]
        public void SetSaveButtonStatusTest()
        {
            _presentationModel.SetSaveButtonStatus(true);
            Assert.AreEqual(true, _presentationModel.IsSaveButtonEnable);
            _presentationModel.SetSaveButtonStatus(false);
            Assert.AreEqual(false, _presentationModel.IsSaveButtonEnable);
        }

        [TestMethod()]
        public void SetNewProductButtonStatusTest()
        {
            _presentationModel.SetNewProductButtonStatus(true);
            Assert.AreEqual(true, _presentationModel.IsNewProductButtonEnable);
            _presentationModel.SetNewProductButtonStatus(false);
            Assert.AreEqual(false, _presentationModel.IsNewProductButtonEnable);
        }

        [TestMethod()]
        public void SetNewButtonStatusTest()
        {
            _presentationModel.SetNewButtonStatus(true);
            Assert.AreEqual(true, _presentationModel.IsNewButtonEnable);
            _presentationModel.SetNewButtonStatus(false);
            Assert.AreEqual(false, _presentationModel.IsNewButtonEnable);
        }

        [TestMethod()]
        public void SetNewCategoryButtonStatusTest()
        {
            _presentationModel.SetNewCategoryButtonStatus(true);
            Assert.AreEqual(true, _presentationModel.IsNewCategoryButtonEnable);
            _presentationModel.SetNewCategoryButtonStatus(false);
            Assert.AreEqual(false, _presentationModel.IsNewCategoryButtonEnable);
        }

        [TestMethod()]
        public void IsNowAndPreviousCategoryDifferentTest()
        {
            _presentationModel.PreviousCategory = "test";
            _presentationModel.SelectedCategory = "test";
            Assert.AreEqual(false, _presentationModel.IsNowAndPreviousCategoryDifferent());
            _presentationModel.SelectedCategory = "test2";
            Assert.AreEqual(true, _presentationModel.IsNowAndPreviousCategoryDifferent());
        }

        [TestMethod()]
        public void SetProductNameToBeChangeTest()
        {
            _presentationModel.SetProductNameToBeChange("New Test");
        }

        [TestMethod()]
        public void ChangeOrderProductDetailTest()
        {
            Order order = new Order("Test", "Test", 0, 0);
            _model.AddOrderInfoToList(order, 0);
            _presentationModel.SetProductNameToBeChange("Test");
            _presentationModel.ChangeOrderProductDetail("Test", "New", "0");
        }
    }
}