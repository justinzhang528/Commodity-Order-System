using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace OrderSystem
{
    public partial class ProductManageForm : Form
    {
        private ProductManageFormPresentationModel _presentationModel;
        private Model _model;
        private Stock _stock;
        private System.IO.DirectoryInfo _directory = new System.IO.DirectoryInfo(Application.StartupPath);
        public ProductManageForm(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
            _presentationModel = new ProductManageFormPresentationModel(_model, _stock);
            InitializeComponent();
            _saveButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_SAVE_BUTTON_ENABLED);
            _newProductButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_NEW_PRODUCT_BUTTON_ENABLED);
            _newButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_NEW_BUTTON_ENABLED);
            _newCategoryButton.DataBindings.Add(Constant.ENABLED, _presentationModel, Constant.IS_NEW_CATEGORY_BUTTON_ENABLED);
            InitializeProductAndCategoryList();
            _productPriceTextBox.KeyPress += new KeyPressEventHandler(NumberHandleKeyPress);
            _productListBox.Click += SelectProductListBoxEventHandler;
            _categoryListBox.Click += SelectCategoryListBoxEventHandler;
            _productNameTextBox.TextChanged += IsProductTextChanging;
            _productPriceTextBox.TextChanged += IsProductTextChanging;
            _productImagePathTextBox.TextChanged += IsProductTextChanging;
            _productIntroductionRichBox.TextChanged += IsProductTextChanging;
            _productCategoryComboBox.SelectedIndexChanged += IsProductTextChanging;
            _categoryNameTextBox.TextChanged += IsCategoryTextChanging;
            _browseButton.Click += BrowseFile;
            _newProductButton.Click += ClickNewProductButtonEventHandler;
            _newCategoryButton.Click += ClickNewCategoryButtonEventHandler;
            _saveButton.Click += ClickSaveButtonEventHandler;
            _newButton.Click += ClickNewButtonEventHandler;

        }

        //初始化商品列表
        public void InitializeProductAndCategoryList()
        {
            _productListBox.Items.Clear();
            _categoryListBox.Items.Clear();
            for (int i = 0; i < _stock.GetCategoryCount(); i++)
            {
                AddCategoryToListBox(i);
                for (int j = 0; j < GetProductCount(i); j++)
                {
                    _productListBox.Items.Add(_model.GetProductName(i, j));
                }
            }
        }

        //添加類別名稱到ListBox
        private void AddCategoryToListBox(int category)
        {
            _categoryListBox.Items.Add(_stock.GetProductCategoryName(category));
        }

        //限制只能输入數字
        private void NumberHandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //瀏覽檔案
        private void BrowseFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "開啟";
            dialog.InitialDirectory = _directory.Parent.Parent.FullName + @"\Images\";
            dialog.Filter = "image files (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|" + "All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _productImagePathTextBox.Text = @"\Images\" + Path.GetFileNameWithoutExtension((dialog.FileName)) + Path.GetExtension((dialog.FileName));
            }
        }

        //商品文字改動時的觸發事件
        private void IsProductTextChanging(object sender, EventArgs e)
        {
            if (_productListBox.SelectedIndex < 0 && (_saveButton.Text == Constant.SAVE))
                return;
            int product = _model.ProductNumber;
            int category = _model.CategoryNumber;
            int number;
            _presentationModel.SelectedCategory = _productCategoryComboBox.Text;
            _presentationModel.SetSaveButtonStatus(_productNameTextBox.Text != "" && !_model.IsNumeric(_productNameTextBox.Text) && _productPriceTextBox.Text != "" && int.TryParse(_productPriceTextBox.Text, out number) && number > 0 && _productCategoryComboBox.Text != "" && _productImagePathTextBox.Text != "" && _productIntroductionRichBox.Text != "" && (_productNameTextBox.Text != _stock.GetProductName(category, product) || _productPriceTextBox.Text != _stock.GetProductPrice(category, product).ToString() || _productIntroductionRichBox.Text != _stock.GetProductDescription(category, product) || _productCategoryComboBox.Text != _stock.GetProductCategoryName(category) || _productImagePathTextBox.Text != @"\Images\" + _stock.GetProductImagePath(category, product)));
        }

        //類別文字改動時的觸發事件
        private void IsCategoryTextChanging(object sender, EventArgs e)
        {
            if (_presentationModel.IsNewCategoryButtonEnable)
                return;
            if (_categoryNameTextBox.Text != "")
                _presentationModel.SetNewButtonStatus(true);
            else
                _presentationModel.SetNewButtonStatus(false);
        }

        //點擊新增商品按鈕的觸發事件
        private void ClickNewProductButtonEventHandler(object sender, EventArgs e)
        {
            _presentationModel.SetNewProductButtonStatus(false);
            _productListBox.SelectedIndex = -1;
            _productDetailGroupBox.Text = Constant.NEW_PRODUCT;
            _saveButton.Text = Constant.NEW;
            ClearProductDetail();
        }

        //點擊新增商品按鈕的觸發事件
        private void ClickNewCategoryButtonEventHandler(object sender, EventArgs e)
        {
            _categoryListBox.SelectedIndex = -1;
            _presentationModel.SetNewCategoryButtonStatus(false);
            _categoryNameTextBox.Clear();
            _productListRichTextBox.Clear();
            _categoryDetailGroupBox.Text = Constant.NEW + Constant.CATEGORY;
        }

        //點擊儲存按鈕的觸發事件
        private void ClickSaveButtonEventHandler(object sender, EventArgs e)
        {
            _presentationModel.SetSaveButtonStatus(false);
            _categoryNameTextBox.Clear();
            _productListRichTextBox.Clear();
            _categoryListBox.SelectedIndex = -1;
            if (_saveButton.Text == Constant.SAVE)
            {
                SaveChangingOfProductDetail();
            }
            else
            {
                SaveNewProduct();
            }
            _model.UpdateInventoryList();
        }

        //點擊新增按鈕的觸發事件
        private void ClickNewButtonEventHandler(object sender, EventArgs e)
        {
            _stock.AddNewCategory(_categoryNameTextBox.Text);
            InitializeProductAndCategoryList();
            _productCategoryComboBox.Items.Add(_categoryNameTextBox.Text);
            _presentationModel.SetNewButtonStatus(false);
            _presentationModel.SetNewCategoryButtonStatus(true);
            _categoryNameTextBox.Clear();
            _categoryDetailGroupBox.Text = Constant.CATEGORY;
            _model.AddNewCategoryTabPage();
        }

        //保存商品信息的更改
        private void SaveChangingOfProductDetail()
        {
            SetProductDetail();
            _productListBox.Items[_productListBox.SelectedIndex] = _productNameTextBox.Text;
            _presentationModel.ChangeOrderProductDetail(_productNameTextBox.Text, _productCategoryComboBox.Text, _productPriceTextBox.Text);
            if (_presentationModel.IsNowAndPreviousCategoryDifferent())
            {
                ChangeProductCategory();
                InitializeProductAndCategoryList();
            }
        }

        //保存新的商品
        private void SaveNewProduct()
        {
            _presentationModel.SetNewProductButtonStatus(true);
            _stock.AddNewProduct(_productCategoryComboBox.SelectedIndex, AddStringToList(), 1);
            _model.CategoryNumber = _productCategoryComboBox.SelectedIndex;
            ClearProductDetail();
            InitializeProductAndCategoryList();
        }

        //更換商品的類別
        private void ChangeProductCategory()
        {
            int category = _model.CategoryNumber;
            int product = _model.ProductNumber;
            _stock.AddNewProduct(_productCategoryComboBox.SelectedIndex, AddStringToList(), GetProductStockQuantity(category, product));
            _stock.RemoveProduct(category, product);
        }

        //回傳商品庫存數量
        private int GetProductStockQuantity(int category, int product)
        {
            return _stock.GetProductStockQuantity(category, product);
        }

        //添加字串到list中并回傳
        private List<string> AddStringToList()
        {
            List<string> list = new List<string>();
            list.Add(_productNameTextBox.Text);
            list.Add(_productIntroductionRichBox.Text);
            list.Add(_productPriceTextBox.Text);
            list.Add(_productImagePathTextBox.Text.Replace(@"\Images\", ""));
            return list;
        }

        //設定商品的各種信息
        private void SetProductDetail()
        {
            int category = _model.CategoryNumber;
            int product = _model.ProductNumber;
            _stock.SetProductName(category, product, _productNameTextBox.Text);
            _stock.SetProductPrice(category, product, int.Parse(_productPriceTextBox.Text));
            _stock.SetProductDescription(category, product, _productIntroductionRichBox.Text);
            _stock.SetProductImagePath(category, product, _productImagePathTextBox.Text.Replace(@"\Images\", ""));
        }

        //返回商品數量
        private int GetProductCount(int index)
        {
            return _stock.GetProductCount(index);
        }

        //選取商品列表的觸發事件
        private void SelectProductListBoxEventHandler(object sender, EventArgs e)
        {
            _productDetailGroupBox.Text = Constant.EDIT_PRODUCT;
            _saveButton.Text = Constant.SAVE;
            _presentationModel.SetNewProductButtonStatus(true);
            int index = _productListBox.SelectedIndex;
            _model.ConvertFromIndexToProductNumber(index);
            int category = _model.CategoryNumber;
            int product = _model.ProductNumber;
            _productCategoryComboBox.SelectedIndex = category;
            _productNameTextBox.Text = _stock.GetProductName(category, product);
            _productPriceTextBox.Text = _stock.GetProductPrice(category, product).ToString();
            _productIntroductionRichBox.Text = _stock.GetProductDescription(category, product);
            _productImagePathTextBox.Text = @"\Images\" + _stock.GetProductImagePath(category, product);
            _presentationModel.SetSaveButtonStatus(false);
            _presentationModel.PreviousCategory = _productCategoryComboBox.Text;
            _presentationModel.SetProductNameToBeChange(_productNameTextBox.Text);
        }

        //選取類別列表的觸發事件
        private void SelectCategoryListBoxEventHandler(object sender, EventArgs e)
        {
            int index = _categoryListBox.SelectedIndex;
            if (index < 0)
                return;
            _categoryNameTextBox.Text = _stock.GetProductCategoryName(index);
            _productListRichTextBox.Clear();
            _categoryDetailGroupBox.Text = Constant.CATEGORY;
            _presentationModel.SetNewCategoryButtonStatus(true);
            _presentationModel.SetNewButtonStatus(false);
            for (int i = 0; i < _stock.GetProductCount(index); i++)
            {
                AddProductNameToRichTextBox(index, i);
            }
        }

        //添加當前類別的商品到richbox中
        private void AddProductNameToRichTextBox(int category, int product)
        {
            _productListRichTextBox.Text += _stock.GetProductName(category , product) + Constant.CHARACTER_ENTER;
        }

        //清楚商品信息
        private void ClearProductDetail()
        {
            _productCategoryComboBox.SelectedIndex = -1;
            _productNameTextBox.Clear();
            _productPriceTextBox.Clear();
            _productIntroductionRichBox.Clear();
            _productImagePathTextBox.Clear();
        }
    }
}
