using System.ComponentModel;

namespace OrderSystem
{
    public class ProductManageFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _isSaveButtonEnable = false;
        private bool _isNewProductButtonEnable = true;
        private bool _isNewCategoryButtonEnable = true;
        private bool _isNewButtonEnable = false;
        private string _previousCategory = "";
        private string _selectedCategory = "";
        private string _productNameToBeChange = "";
        private Model _model;
        private Stock _stock;

        public ProductManageFormPresentationModel(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
        }

        //DataBinding通知函式
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsSaveButtonEnable
        {
            get
            {
                return _isSaveButtonEnable;
            }
        }

        public bool IsNewProductButtonEnable
        {
            get
            {
                return _isNewProductButtonEnable;
            }
        }

        public bool IsNewCategoryButtonEnable
        {
            get
            {
                return _isNewCategoryButtonEnable;
            }
        }

        public bool IsNewButtonEnable
        {
            get
            {
                return _isNewButtonEnable;
            }
        }

        //設定儲存按鈕的狀態
        public void SetSaveButtonStatus(bool enable)
        {
            if (enable)
            {
                _isSaveButtonEnable = true;
            }
            else
            {
                _isSaveButtonEnable = false;
            }
            Notify(Constant.IS_SAVE_BUTTON_ENABLED);
        }

        //設定新增商品按鈕的狀態
        public void SetNewProductButtonStatus(bool enable)
        {
            if (enable)
            {
                _isNewProductButtonEnable = true;
            }
            else
            {
                _isNewProductButtonEnable = false;
            }
            Notify(Constant.IS_NEW_PRODUCT_BUTTON_ENABLED);
        }

        //設定新增按鈕的狀態
        public void SetNewButtonStatus(bool enable)
        {
            if (enable)
            {
                _isNewButtonEnable = true;
            }
            else
            {
                _isNewButtonEnable = false;
            }
            Notify(Constant.IS_NEW_BUTTON_ENABLED);
        }

        //設定新增類別按鈕的狀態
        public void SetNewCategoryButtonStatus(bool enable)
        {
            if (enable)
            {
                _isNewCategoryButtonEnable = true;
            }
            else
            {
                _isNewCategoryButtonEnable = false;
            }
            Notify(Constant.IS_NEW_CATEGORY_BUTTON_ENABLED);
        }

        public string PreviousCategory
        {
            get
            {
                return _previousCategory;
            }
            set
            {
                _previousCategory = value;
            }
        }

        public string SelectedCategory
        {
            get
            {
                return _selectedCategory;
            }
            set
            {
                _selectedCategory = value;
            }
        }

        //比較現在與之前的類別值
        public bool IsNowAndPreviousCategoryDifferent()
        {
            return SelectedCategory != PreviousCategory;
        }

        //設定待改變的商品名稱
        public void SetProductNameToBeChange(string name)
        {
            _productNameToBeChange = name;
        }

        //改變訂單商品的信息
        public void ChangeOrderProductDetail(string name, string category, string price)
        {
            for (int i = 0; i < GetOrderCount(); i++)
            {
                if (_productNameToBeChange == _model.GetOrderProductName(i))
                {
                    SetOrderProductName(i, name);
                    SetOrderProductPrice(i, int.Parse(price));
                    SetOrderProductCategory(i, category);
                    _productNameToBeChange = name;
                    break;
                }
            }
        }

        //回傳訂單數量
        private int GetOrderCount()
        {
            return _model.GetOrderCount();
        }

        //設定訂單商品名稱
        private void SetOrderProductName(int index, string name)
        {
            _model.SetOrderProductName(index, name);
        }

        //設定訂單商品類別
        private void SetOrderProductCategory(int index, string category)
        {
            _model.SetOrderProductCategory(index, category);
        }

        //設定訂單商品價格
        private void SetOrderProductPrice(int index, int price)
        {
            _model.SetOrderProductPrice(index, price);
        }
    }
}
