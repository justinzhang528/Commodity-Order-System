using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class MenuFormPresentationModelTests
    {
        MenuFormPresentationModel _presentationModel = new MenuFormPresentationModel();

        //回傳order按鈕狀態測試
        [TestMethod()]
        public void IsOrderButtonEnableTest()
        {
            _presentationModel.PressOrderButton();
            Assert.AreEqual(false, _presentationModel.IsOrderButtonEnable());
        }

        //回傳inventory按鈕狀態測試
        [TestMethod()]
        public void IsInventoryButtonEnableTest()
        {
            _presentationModel.PressInventoryButton();
            Assert.AreEqual(false, _presentationModel.IsInventoryButtonEnable());
        }

        //回傳product manage按鈕狀態測試
        [TestMethod()]
        public void IsProductManageButtonEnableTest()
        {
            _presentationModel.PressProductManageButton();
            Assert.AreEqual(false, _presentationModel.IsProductManageButtonEnable());
        }

        //關閉order按鈕測試
        [TestMethod()]
        public void CloseOrderFormButtonTest()
        {
            _presentationModel.CloseOrderFormButton();
            Assert.AreEqual(true, _presentationModel.IsOrderButtonEnable());
        }

        //關閉inventory按鈕測試
        [TestMethod()]
        public void CloseInventoryFormButtonTest()
        {
            _presentationModel.CloseInventoryFormButton();
            Assert.AreEqual(true, _presentationModel.IsInventoryButtonEnable());
        }

        //關閉product manage按鈕測試
        [TestMethod()]
        public void CloseProductManageFormButtonTest()
        {
            _presentationModel.CloseProductManageFormButton();
            Assert.AreEqual(true, _presentationModel.IsProductManageButtonEnable());
        }
    }
}