using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class OrderFormPresentationModelTests
    {
        OrderFormPresentationModel _presentationModel;
        Model _model;
        Stock _stock;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
            _presentationModel = new OrderFormPresentationModel(_model, _stock);
        }

        [TestMethod()]
        public void InitializeProductDetailTest()
        {
            _presentationModel.InitializeProductDetail();
        }

        [TestMethod()]
        public void GetProductCategoryNameTest()
        {
            Assert.AreEqual("CPU", _presentationModel.GetProductCategoryName(1));
        }

        [TestMethod()]
        public void SelectProductEventHandlerTest()
        {
            _presentationModel.SelectProductEventHandler(0, 0);
        }

        [TestMethod()]
        public void CheckProductIsInOrderListTest()
        {
            Order order = new Order("ASUS Z87-DELUX", "", 0, 0);
            _model.AddOrderInfoToList(order, 0);
            _presentationModel.SelectProductEventHandler(0, 0);
            _presentationModel.CheckProductIsInOrderList();
        }

        [TestMethod()]
        public void CheckProductIsInOrderListTest1()
        {
            _presentationModel.CheckProductIsInOrderList(0, 0);
        }

        [TestMethod()]
        public void SetAddButtonEnableTest()
        {
            _presentationModel.SetAddButtonEnable(0, 0);
            _presentationModel.SetAddButtonEnable(1, 1);
            Assert.AreEqual(true, _presentationModel.IsAddButtonEnable);
        }

        [TestMethod()]
        public void SetPreviousButtonStatusTest()
        {
            _presentationModel.SetPageNumber(0);
            _presentationModel.SetPreviousButtonStatus();
            Assert.AreEqual(false, _presentationModel.IsPreviousButtonEnable);
            _presentationModel.SetPageNumber(2);
            _presentationModel.SetPreviousButtonStatus();
            Assert.AreEqual(true, _presentationModel.IsPreviousButtonEnable);
        }

        [TestMethod()]
        public void SetNextButtonStatusTest()
        {
            _presentationModel.SetPageNumber(0);
            _presentationModel.SetNextButtonStatus();
            Assert.AreEqual(false, _presentationModel.IsNextButtonEnable);
            _presentationModel.SetCurrentPageCount(0);
            _presentationModel.SetNextButtonStatus();
            Assert.AreEqual(true, _presentationModel.IsNextButtonEnable);
        }

        [TestMethod()]
        public void SetProductCategoryTest()
        {
            _presentationModel.SetProductCategory("NEW");
        }

        [TestMethod()]
        public void SetTotalPriceLabelStringTest()
        {
            _presentationModel.SetTotalPriceLabelString();
            Assert.AreEqual("總金額：0 元", _presentationModel.TotalPriceLabelString);
            Order order = new Order("ASUS Z87-DELUX", "", 100, 0);
            _model.AddOrderInfoToList(order, 100);
            _presentationModel.AddProductToMyOrderList();
            _presentationModel.SetTotalPriceLabelString();
            _presentationModel.InitializePageNumber();
            Assert.AreEqual("總金額：100 元", _presentationModel.TotalPriceLabelString);
            Assert.AreEqual(true, _presentationModel.IsOrderButtonEnable);
            Assert.AreEqual("" + Constant.CHARACTER_ENTER + "", _presentationModel.ProductDetail);
            Assert.AreEqual("", _presentationModel.ProductPrice);
            Assert.AreEqual("", _presentationModel.ProductQuantity);
        }

        [TestMethod()]
        public void SetOrderButtonStatusTest()
        {
            Assert.AreEqual(false, _presentationModel.IsOrderButtonEnable);
        }

        [TestMethod()]
        public void GetPageLabelTextTest()
        {
            _presentationModel.GetPageLabelText(0);
        }

        [TestMethod()]
        public void GetAddCountTest()
        {
            _presentationModel.GetAddCount(0);
            _presentationModel.SetPageNumber(2);
            _presentationModel.GetAddCount(1);
        }

        [TestMethod()]
        public void GetStartIndexTest()
        {
            _presentationModel.SetPageNumber(0);
            Assert.AreEqual(0, _presentationModel.GetStartIndex());
        }

        [TestMethod()]
        public void ReduceProductQuantityTest()
        {
            Order order = new Order("ASUS Z87-DELUX", "", 100, 0);
            _model.AddOrderInfoToList(order, 100);
            _presentationModel.ReduceProductQuantity();
        }

        [TestMethod()]
        public void GetQuantityTest()
        {
            _presentationModel.GetQuantity(0, 0);
        }

        [TestMethod()]
        public void GetReduceQuantityTest()
        {
            Order order = new Order("ASUS Z87-DELUX", "", 100, 0);
            _model.AddOrderInfoToList(order, 100);
            _presentationModel.GetReduceQuantity(1, 0);
        }
    }
}