using System;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class SupplementForm : Form
    {
        Model _model;
        Stock _stock;
        SupplementFormPresentationModel _presentationModel;
        public SupplementForm(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
            _presentationModel = new SupplementFormPresentationModel(_model, _stock);
            InitializeComponent();
            _supplyQuantityTextBox.KeyPress += new KeyPressEventHandler(NumberHandleKeyPress);
            _supplyQuantityTextBox.TextChanged += ChangeTextHandler;
        }

        //限制只能输入數字
        private void NumberHandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //文字改變時觸發事件
        private void ChangeTextHandler(object sender, EventArgs e)
        {
            _presentationModel.IsNullString(((TextBox)sender).Text);
            _submitButton.Enabled = _presentationModel.IsSubmitButtonEnable();
        }

        //回傳輸入的數量
        public int GetInputQuantity()
        {
            return int.Parse(_supplyQuantityTextBox.Text);
        }

        //清空輸入框數量
        public void ClearInputQuantity()
        {
            _supplyQuantityTextBox.Clear();
        }

        //設定輸入數量
        public void SetInputQuantity()
        {
            _presentationModel.SetInputQuantity(int.Parse(_supplyQuantityTextBox.Text));
        }

        //補貨
        public void SupplyProduct()
        {
            _presentationModel.Supplement(_model.CategoryNumber, _model.ProductNumber);
        }

        //設定顯示在視窗的商品信息
        public void SetProductDisplayDetail(int category, int product)
        {
            _productNameLabel.Text = Constant.PRODUCT_NAME + _model.GetProductName(category, product);
            _productCategoryLabel.Text = Constant.PRODUCT_CATEGORY + _model.GetProductCategoryName(category);
            _productPriceLabel.Text = Constant.PRODUCT_PRICE_LABEL + _model.GetProductPrice(category, product).ToString(Constant.CHARACTER_NUMBER_SEPARATOR);
            _stockQuantityLabel.Text = Constant.STOCK_QUANTITY + _model.GetProductStockQuantity(category, product).ToString();
        }
    }
}
