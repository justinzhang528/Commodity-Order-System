using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class PaymentFormPresentationModelTests
    {
        PaymentFormPresentationModel _presentationModel;
        Model _model;
        Stock _stock;
        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
            _presentationModel = new PaymentFormPresentationModel(_model);
        }

        [TestMethod()]
        public void SetButtonEnableStatusTest()
        {
            _presentationModel.SetButtonEnableStatus();
            for (int i = 0; i < 11; i++)
            {
                _presentationModel.SetFormatCorrectValue(i);
            }
            _presentationModel.SetButtonEnableStatus();
            Assert.AreEqual(true, _presentationModel.IsSubmitButtonEnable());
        }

        [TestMethod()]
        public void IsSubmitButtonEnableTest()
        {
            Assert.AreEqual(true, _presentationModel.IsSubmitButtonEnable());
        }

        [TestMethod()]
        public void SetFormatCorrectValueTest()
        {
            _presentationModel.SetFormatCorrectValue(0);
            Assert.AreEqual(true, _presentationModel.GetCorrectValue(0));
        }

        [TestMethod()]
        public void GetCorrectValueTest()
        {
            Assert.AreEqual(false, _presentationModel.GetCorrectValue(0));
        }

        [TestMethod()]
        public void IsFormatCorrectTest()
        {
            Assert.AreEqual(false, _presentationModel.IsFormatCorrect(0));
        }

        [TestMethod()]
        public void CheckFormatTest()
        {
            _presentationModel.CheckFormat(0, "", 0);
            _presentationModel.CheckFormat(2, "", 0);
            _presentationModel.CheckFormat(7, "", 0);
            _presentationModel.CheckFormat(8, "", 0);
        }

        [TestMethod()]
        public void CheckNameFormatTest()
        {
            _presentationModel.CheckNameFormat("test", 0);
            _presentationModel.CheckNameFormat("", 0);
        }

        [TestMethod()]
        public void CheckIsNumberTest()
        {
            _presentationModel.CheckIsNumber("123", 4, 0);
            _presentationModel.CheckIsNumber("test", 3, 0);
        }

        [TestMethod()]
        public void CheckMailFormatTest()
        {
            _presentationModel.CheckMailFormat("test.com", 0);
            _presentationModel.CheckMailFormat("test@yahoo.com", 0);
        }

        [TestMethod()]
        public void CheckIsNullStringTest()
        {
            _presentationModel.CheckIsNullString("", 0);
            _presentationModel.CheckIsNullString("test", 0);
        }

        [TestMethod()]
        public void IsInputEnableTest()
        {
            Assert.AreEqual(true, _presentationModel.IsInputEnable());
        }

        [TestMethod()]
        public void IsValidNameTest()
        {
            Assert.AreEqual(true, _presentationModel.IsValidName("test"));
            Assert.AreEqual(false, _presentationModel.IsValidName("test0"));
        }
    }
}