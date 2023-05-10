using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class SupplementFormPresentationModelTests
    {
        Model _model;
        Stock _stock;
        SupplementFormPresentationModel _presentationModel;

        //初始化測試數據
        [TestInitialize()]
        public void Initialize()
        {
            _stock = new Stock();
            _model = new Model(_stock);
            _presentationModel = new SupplementFormPresentationModel(_model, _stock);
        }

        [TestMethod()]
        public void IsSubmitButtonEnableTest()
        {
            Assert.AreEqual(false, _presentationModel.IsSubmitButtonEnable());
            _presentationModel.IsNullString("test");
            Assert.AreEqual(true, _presentationModel.IsSubmitButtonEnable());
        }

        [TestMethod()]
        public void IsNullStringTest()
        {
            _presentationModel.IsNullString("");
            Assert.AreEqual(false, _presentationModel.IsSubmitButtonEnable());
            _presentationModel.IsNullString("test");
            Assert.AreEqual(true, _presentationModel.IsSubmitButtonEnable());
        }

        [TestMethod()]
        public void SetInputQuantityTest()
        {
            _presentationModel.SetInputQuantity(10);
            Assert.AreEqual(10, _presentationModel.GetInputQuantity());
        }

        [TestMethod()]
        public void GetInputQuantityTest()
        {
            _presentationModel.SetInputQuantity(99);
            Assert.AreEqual(99, _presentationModel.GetInputQuantity());
        }

        [TestMethod()]
        public void SupplementTest()
        {
            _presentationModel.SetInputQuantity(10);
            _presentationModel.Supplement(0, 0);
            Assert.AreEqual(20, _stock.GetProductStockQuantity(0, 0));
        }
    }
}