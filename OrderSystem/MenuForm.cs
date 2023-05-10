using System;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MenuForm : Form
    {
        private OrderForm _orderForm;
        private InventoryForm _inventoryForm;
        private ProductManageForm _productManageForm;
        private MenuFormPresentationModel _presentationModel = new MenuFormPresentationModel();
        public MenuForm(OrderForm orderForm, InventoryForm inventoryForm, ProductManageForm productManageForm)
        {
            InitializeComponent();
            _orderForm = orderForm;
            _inventoryForm = inventoryForm;
            _productManageForm = productManageForm;
            _orderSystemButton.Click += EnterOrderSystemInterface;
            _inventorySystemButton.Click += EnterInventorySystemInterface;
            _productManageSystemButton.Click += EnterProductManageSystemInterface;
            _orderForm.FormClosing += new FormClosingEventHandler(this.SetOrderSystemButtonEnable);
            _inventoryForm.FormClosing += new FormClosingEventHandler(this.SetInventorySystemButtonEnable);
            _productManageForm.FormClosing += new FormClosingEventHandler(this.SetProductManageSystemButtonEnable);
            _exitButton.Click += ExitApplication;
        }

        //進入訂購系統
        private void EnterOrderSystemInterface(object sender, EventArgs e)
        {
            _presentationModel.PressOrderButton();
            _orderSystemButton.Enabled = _presentationModel.IsOrderButtonEnable();
            _orderForm.Show();            
        }

        //進入庫存系統
        private void EnterInventorySystemInterface(object sender, EventArgs e)
        {
            _presentationModel.PressInventoryButton();
            _inventorySystemButton.Enabled = _presentationModel.IsInventoryButtonEnable();
            _inventoryForm.Show();
        }

        //進入商品管理系統
        private void EnterProductManageSystemInterface(object sender, EventArgs e)
        {
            _presentationModel.PressProductManageButton();
            _productManageSystemButton.Enabled = _presentationModel.IsProductManageButtonEnable();
            _productManageForm.Show();
        }

        //退出系統
        private void ExitApplication(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        //開啟訂購系統按鈕
        private void SetOrderSystemButtonEnable(object sender, FormClosingEventArgs e)
        {
            _orderForm.Hide();
            e.Cancel = true;
            _presentationModel.CloseOrderFormButton();
            _orderSystemButton.Enabled = _presentationModel.IsOrderButtonEnable();
        }

        //開啟庫存系統按鈕
        private void SetInventorySystemButtonEnable(object sender, FormClosingEventArgs e)
        {
            _inventoryForm.Hide();
            e.Cancel = true;
            _presentationModel.CloseInventoryFormButton();
            _inventorySystemButton.Enabled = _presentationModel.IsInventoryButtonEnable();
        }

        //開啟庫存系統按鈕
        private void SetProductManageSystemButtonEnable(object sender, FormClosingEventArgs e)
        {
            _productManageForm.Hide();
            e.Cancel = true;
            _presentationModel.CloseProductManageFormButton();
            _productManageSystemButton.Enabled = _presentationModel.IsProductManageButtonEnable();
        }
    }
}
