using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class OrderForm : Form
    {
        private Model _model;
        private Stock _stock;
        private PaymentForm _paymentForm;
        private OrderFormPresentationModel _presentationModel;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private List<TabPage> _productTabPages = new List<TabPage>();
        private List<TableLayoutPanel> _productTableLayoutPanel = new List<TableLayoutPanel>();
        private List<List<Button>> _productButtons = new List<List<Button>>();
        private System.IO.DirectoryInfo _directory = new System.IO.DirectoryInfo(Application.StartupPath);

        public OrderForm(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
            _presentationModel = new OrderFormPresentationModel(_model, _stock);
            _paymentForm = new PaymentForm(new PaymentFormPresentationModel(_model));
            InitializeComponent();
            _addButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_ADD_BUTTON_ENABLED);
            _nextButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_NEXT_BUTTON_ENABLED);
            _previousButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_PREVIOUS_BUTTON_ENABLED);
            _orderButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_ORDER_BUTTON_ENABLED);
            _priceLabel.DataBindings.Add(Constant.TEXT, _presentationModel, Constant.PRODUCT_PRICE);
            _stockQuantityLabel.DataBindings.Add(Constant.TEXT, _presentationModel, Constant.PRODUCT_QUANTITY);
            _productDescription.DataBindings.Add(Constant.TEXT, _presentationModel, Constant.PRODUCT_DETAIL);
            _totalPriceLabel.DataBindings.Add(Constant.TEXT, _presentationModel, Constant.TOTAL_PRICE_LABEL_STRING);
            AddProductButton();
            UpdateCategoryTabPages();
            InitializePageLabelAndButton();
            _model._modelChanged += UpdateProductButton;
            _model._modelChanged += UpdateOrderList;
            _model._modelChangedCategory += AddNewCategoryTabPage;
            foreach (DataGridViewColumn column in _myOrderDataGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            _productCategoryTabControl.SelectedIndexChanged += ChangeProductCategory;
            _addButton.Click += AddButtonHandler;
            _myOrderDataGridView.CellClick += DeleteButtonClickHandler;
            _myOrderDataGridView.CellPainting += PaintDataGridViewCell;
            _myOrderDataGridView.CellEndEdit += EndCellEditEventHandler;
            _myOrderDataGridView.Columns[Constant.FOUR].ReadOnly = false;
            _previousButton.Click += ChangePageClickHandler;
            _nextButton.Click += ChangePageClickHandler;
        }

        //初始化頁面標籤及翻頁按鈕
        private void InitializePageLabelAndButton()
        {
            _presentationModel.SetCurrentPageCount(_productCategoryTabControl.SelectedIndex);
            _presentationModel.InitializePageNumber();
            UpdateChangePageButtonStatus();
            _pageLabel.Text = _presentationModel.GetPageLabelText(_productCategoryTabControl.SelectedIndex);
        }

        //更新按鈕狀態
        private void UpdateChangePageButtonStatus()
        {
            _presentationModel.SetNextButtonStatus();
            _presentationModel.SetPreviousButtonStatus();
            CancelSelectProductStatus();
        }

        //翻頁時的觸發事件
        private void ChangePageClickHandler(object sender, EventArgs e)
        {
            _presentationModel.SetAddButtonEnable(0, 0);
            CancelSelectProductStatus();
            _presentationModel.SetPageNumber(int.Parse(((Button)sender).Tag.ToString()));
            UpdateChangePageButtonStatus();
            _pageLabel.Text = _presentationModel.GetPageLabelText(_productCategoryTabControl.SelectedIndex);
            RefreshProductButton();
        }

        //cell完成編輯的觸發事件
        private void EndCellEditEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                if (e.ColumnIndex == Constant.FOUR)
                {
                    _model.SetOrderInputQuantity(_myOrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    _model.SetCategoryAndProductIndex(e.RowIndex);
                    if (_model.GetCompareInputQuantityAndStockQuantity())
                    {
                        _myOrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = GetProductStockQuantity();
                        SetTotalPriceValue(_myOrderDataGridView.Rows[e.RowIndex]);
                        MessageBox.Show("庫存不足", "庫存狀態");
                    }
                    _model.SetOrderProductQuantityAndTotalPrice(e.RowIndex);                    
                    SetTotalPriceValue(_myOrderDataGridView.Rows[e.RowIndex]);
                    _presentationModel.SetTotalPriceLabelString();
                }
        }

        //設定DataGridViewRow的Cell數值
        private void SetTotalPriceValue(DataGridViewRow row)
        {
            row.Cells[Constant.FIVE].Value = _model.GetOrderProductTotalPrice().ToString(Constant.CHARACTER_NUMBER_SEPARATOR);
        }

        //返回商品庫存數量
        private int GetProductStockQuantity()
        {
            return _model.GetProductStockQuantity();
        }

        //為DataGridView的按鈕添加圖標
        private void PaintDataGridViewCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = Properties.Resources.delete.Width;
                var height = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - height) / Constant.TWO;
                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, width, height));
                e.Handled = true;
            }
        }

        //新增商品按鈕
        private void AddProductButton()
        {
            for (int i = 0; i < GetCategoryCount(); i++)
            {
                _productButtons.Add(new List<Button>());
                for (int j = 0; j < GetProductCount(i); j++ )
                    AddProductButtonHandler(i, j);
            }
        }

        //新增商品按鈕時間
        private void AddProductButtonHandler(int category, int product)
        {
            _productButtons[category].Add(new Button());
            _productButtons[category][product].Dock = DockStyle.Fill;
            _productButtons[category][product].TabIndex = (category * Constant.HUNDRED) + product;
            _productButtons[category][product].BackgroundImage = Image.FromFile(_directory.Parent.Parent.FullName + @"\Images\" + _model.GetProductImagePath(category, product));
            _productButtons[category][product].BackgroundImageLayout = ImageLayout.Zoom;
            _productButtons[category][product].Click += ClickProductButtonHandler;
        }

        //更新全部商品按鈕
        public void UpdateProductButton()
        {
            _productButtons.Clear();
            GC.Collect(1);
            AddProductButton();
            InitializePageLabelAndButton();
            RefreshProductButton(); 
        }

        //取得種類號碼
        private int GetCategoryNumber()
        {
            return _model.CategoryNumber;
        }

        //取得商品號碼
        private int GetProductNumber()
        {
            return _model.ProductNumber;
        }

        //取得商品的種類數量
        private int GetCategoryCount()
        {
            return _model.GetCategoryCount();
        }

        //取得商品數量
        private int GetProductCount(int category)
        {
            return _model.GetProductCount(category);
        }

        //刷新商品按鈕的顯示
        private void RefreshProductButton()
        {
            int index = _productCategoryTabControl.SelectedIndex;
            _productTableLayoutPanel[index].Controls.Clear();
            for (int i = GetStartIndex(); i < GetStartIndex() + _presentationModel.GetAddCount(index); i++)
                _productTableLayoutPanel[index].Controls.Add(_productButtons[_productCategoryTabControl.SelectedIndex][i]);
        }

        //取得開始索引值
        private int GetStartIndex()
        {
            return _presentationModel.GetStartIndex();
        }

        //未選擇商品按鈕時的狀態
        private void CancelSelectProductStatus()
        {
            _productDescription.Text = null;
            _priceLabel.Text = null;
            _stockQuantityLabel.Text = null;
        }

        //新增TabPages控件
        private void UpdateCategoryTabPages()
        {
            for (int i = 0; i < _model.GetCategoryCount(); i++)
            {
                AddNewTabPage(i);
                for (int j = 0; j < Constant.BUTTON_PER_PAGE; j++)
                    _productTableLayoutPanel[i].Controls.Add(_productButtons[i][j]);
            }
        }

        //新增tabpage
        private void AddNewTabPage(int index)
        {
            _productTabPages.Add(new TabPage());
            _productTabPages[index].Text = _presentationModel.GetProductCategoryName(index);
            _productCategoryTabControl.TabPages.Add(_productTabPages[index]);
            AddProductTableLayoutPanel(index);
            _productCategoryTabControl.TabPages[index].Controls.Add(_productTableLayoutPanel[index]);
            _productTableLayoutPanel[index].CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        //新增類別tabpage
        private void AddNewCategoryTabPage()
        {
            AddNewTabPage(_stock.GetCategoryCount() - 1);
        }

        //新增商品TableLayoutPanel
        private void AddProductTableLayoutPanel(int index)
        {
            _productTableLayoutPanel.Add(new TableLayoutPanel());
            _productTableLayoutPanel[index].RowCount = 2;
            for (int i = 0; i < _productTableLayoutPanel[index].RowCount; i++)
                _productTableLayoutPanel[index].RowStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _productTableLayoutPanel[index].ColumnCount = 3;
            for (int i = 0; i < _productTableLayoutPanel[index].ColumnCount; i++)
                _productTableLayoutPanel[index].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F)); 
            _productTableLayoutPanel[index].Dock = DockStyle.Fill;
        }

        //點擊刪除按鈕的觸發事件
        private void DeleteButtonClickHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    _myOrderDataGridView.Rows.Remove(_myOrderDataGridView.Rows[e.RowIndex]);
                    _model.RemoveOrderInfoFromList(e.RowIndex);
                }
            }
            _presentationModel.SetTotalPriceLabelString();
        }

        //點擊商品按鈕時的觸發事件
        private void ClickProductButtonHandler(object sender, EventArgs e)
        {
            _presentationModel.SelectProductEventHandler(((Button)sender).TabIndex / Constant.HUNDRED, ((Button)sender).TabIndex % Constant.HUNDRED);
            for (int i = 0; i < _myOrderDataGridView.RowCount; i++)
                _presentationModel.CheckProductIsInOrderList();
            _presentationModel.SetAddButtonEnable(1, _model.GetProductStockQuantity(((Button)sender).TabIndex / Constant.HUNDRED, ((Button)sender).TabIndex % Constant.HUNDRED));
        }

        //添加選中商品到我的訂單列表中
        private void AddButtonHandler(object sender, EventArgs e)
        {
            _presentationModel.SetAddButtonEnable(0, 0);
            _presentationModel.AddProductToMyOrderList();
            _myOrderDataGridView.Rows.Add("", _model.GetOrderProductName(_myOrderDataGridView.RowCount), _model.GetOrderProductCategory(_myOrderDataGridView.RowCount), _model.GetOrderProductPrice(_myOrderDataGridView.RowCount), 1, _model.GetOrderProductPrice(_myOrderDataGridView.RowCount));
            _presentationModel.SetTotalPriceLabelString();
            CancelSelectProductStatus();
            _presentationModel.InitializeProductDetail();
        }

        //訂購按鈕的觸發事件
        private void OrderButtonHandler(object sender, EventArgs e)
        {
            _paymentForm.ClearThreeNumberSecurityCode();
            if (_paymentForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Constant.ORDER_COMPLETED);
                _presentationModel.ReduceProductQuantity();
                _myOrderDataGridView.Rows.Clear();
                _model.ClearOrderInfo();
                _presentationModel.SetTotalPriceLabelString();
                _model.UpdateInventoryList();
            }
        }

        //更新訂單列表
        public void UpdateOrderList()
        {
            for (int i = 0; i < _model.GetOrderCount(); i++)
            {
                SetOrderDetail(i);
                SetTotalPriceValue(_myOrderDataGridView.Rows[i]);
                _presentationModel.SetTotalPriceLabelString();
            }
        }

        //設定商品信息
        private void SetOrderDetail(int index)
        {
            _myOrderDataGridView.Rows[index].Cells[1].Value = _model.GetOrderProductName(index);
            _myOrderDataGridView.Rows[index].Cells[Constant.TWO].Value = _model.GetOrderProductCategory(index);
            _myOrderDataGridView.Rows[index].Cells[Constant.THREE].Value = _model.GetOrderProductPrice(index);
            _model.SetOrderInputQuantity(_myOrderDataGridView.Rows[index].Cells[Constant.FOUR].Value.ToString());
            _model.SetCategoryAndProductIndex(index);
            _model.SetOrderProductQuantityAndTotalPrice(index);
        }

        //設置當前選中的商品類別
        private void ChangeProductCategory(object sender, EventArgs e)
        {
            CancelSelectProductStatus();
            InitializePageLabelAndButton();
            _pageLabel.Text = _presentationModel.GetPageLabelText(_productCategoryTabControl.SelectedIndex);
            _presentationModel.SetProductCategory(_productCategoryTabControl.SelectedTab.Text);
            RefreshProductButton();
        }
    }
}
