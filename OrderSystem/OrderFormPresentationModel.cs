using System.ComponentModel;

namespace OrderSystem
{
    public class OrderFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Model _model;
        private Stock _stock;
        private string _productName;
        private string _productDescription;
        private string _productCategory;
        private int _productPrice = 0;
        private int _existTime = 0;
        private string _priceString;
        private string _quantityString;
        private string _productTotalPriceLabel;
        private int _productStockQuantity;
        private int _pageCount = 1;
        private int _pageNumber = 1;
        bool _isAddButtonEnable = false;
        bool _isPreviousButtonEnable = false;
        bool _isNextButtonEnable = false;
        bool _isOrderButtonEnable = false;
        public OrderFormPresentationModel(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
            InitializeProductDetail();
        }

        //DataBinding通知函式
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //初始化商品信息
        public void InitializeProductDetail()
        {
            const string DEFAULT_CATEGORY = "主機板";
            const int DEFAULT_PRICE = 0;
            _productName = "";
            _productDescription = "";
            _productCategory = DEFAULT_CATEGORY;
            _productPrice = DEFAULT_PRICE;
            _priceString = "";
            _quantityString = "";
            _productTotalPriceLabel = Constant.TOTAL_PRICE + _model.GetOrderTotalPriceString() + Constant.CHINESE_CURRENCY_CHARACTER;
        }

        //返回商品類別的名稱
        public string GetProductCategoryName(int index)
        {
            return _model.GetProductCategoryName(index);
        }

        //選擇商品時的觸發事件
        public void SelectProductEventHandler(int category, int product)
        {
            _productName = _stock.GetProductName(category, product);
            _productDescription = _stock.GetProductDescription(category, product);
            _productPrice = _stock.GetProductPrice(category, product);
            _productStockQuantity = _stock.GetProductStockQuantity(category, product);
            _priceString = Constant.PRICE + _productPrice.ToString(Constant.CHARACTER_NUMBER_SEPARATOR) + Constant.CHINESE_CURRENCY_CHARACTER;
            _quantityString = Constant.STOCK_QUANTITY + _productStockQuantity.ToString();
            _productCategory = _stock.GetProductCategoryName(category);
            _existTime = 0;
            Notify(Constant.PRODUCT_DETAIL);
            Notify(Constant.PRODUCT_PRICE);
            Notify(Constant.PRODUCT_QUANTITY);
        }

        //判斷當前商品是否已經在訂單里
        public void CheckProductIsInOrderList()
        {
            for (int i = 0; i < _model.GetOrderCount(); i++)
                if (_productName == GetOrderProductName(i))
                    _existTime++;
        }

        //回傳訂單商品數量
        private string GetOrderProductName(int index)
        {
            return _model.GetOrderProductName(index);
        }

        //判斷當前商品是否已經在訂單里
        public void CheckProductIsInOrderList(int productIndex, int orderIndex)
        {
            if (productIndex == orderIndex)
                _existTime++;
        }

        public string ProductDetail
        {
            get
            {
                return _productName + Constant.CHARACTER_ENTER + _productDescription;
            }
        }

        public string ProductPrice
        {
            get
            {
                return _priceString;
            }
        }

        public string ProductQuantity
        {
            get
            {
                return _quantityString;
            }
        }

        //設定Add按鈕狀態
        public void SetAddButtonEnable(int number, int quantity)
        {
            if (number == 0 || quantity == 0 || _existTime > 0)
                _isAddButtonEnable = false;
            else
                _isAddButtonEnable = true;
            Notify(Constant.IS_ADD_BUTTON_ENABLED);
        }

        //設定上一頁按鈕的狀態
        public void SetPreviousButtonStatus()
        {
            if (_pageNumber < Constant.TWO)
                _isPreviousButtonEnable = false;
            else
                _isPreviousButtonEnable = true;
            Notify(Constant.IS_PREVIOUS_BUTTON_ENABLED);
        }

        //設定下一頁按鈕的狀態
        public void SetNextButtonStatus()
        {
            if (_pageNumber >= _pageCount)
                _isNextButtonEnable = false;
            else
                _isNextButtonEnable = true;
            Notify(Constant.IS_NEXT_BUTTON_ENABLED);
        }

        public bool IsPreviousButtonEnable
        {
            get
            {
                return _isPreviousButtonEnable;
            }
        }

        public bool IsNextButtonEnable
        {
            get
            {
                return _isNextButtonEnable;
            }
        }

        public bool IsAddButtonEnable
        {
            get
            {
                return _isAddButtonEnable;
            }
        }

        //回傳Order按鈕狀態
        public bool IsOrderButtonEnable
        {
            get
            {
                return _isOrderButtonEnable;
            }
        }

        //設定商品分類
        public void SetProductCategory(string productCategory)
        {
            _productCategory = productCategory;
        }

        public string TotalPriceLabelString
        {
            get
            {
                return _productTotalPriceLabel;
            }
        }

        //設定總價標籤
        public void SetTotalPriceLabelString()
        {
            _productTotalPriceLabel = Constant.TOTAL_PRICE + _model.GetOrderTotalPriceString() + Constant.CHINESE_CURRENCY_CHARACTER;
            SetOrderButtonStatus();
            Notify(Constant.TOTAL_PRICE_LABEL_STRING);
        }

        //判斷總價金額
        public void SetOrderButtonStatus()
        {
            if (_model.GetOrderTotalPrice() == 0)
                _isOrderButtonEnable = false;
            else
                _isOrderButtonEnable = true;
            Notify(Constant.IS_ORDER_BUTTON_ENABLED);
        }

        //加入商品到我的訂單中
        public void AddProductToMyOrderList()
        {
            _model.AddOrderInfoToList(new Order(_productName, _productCategory, _productPrice, 1), _productPrice);
        }
        
        //設定頁面標籤的文字
        public string GetPageLabelText(int category)
        {
            string text = Constant.PAGE + _pageNumber.ToString() + Constant.SLASH + _pageCount.ToString();
            return text;
        }

        //改變頁碼
        public void SetPageNumber(int number)
        {
            _pageNumber += number;
        }

        //初始化頁碼
        public void InitializePageNumber()
        {
            _pageNumber = 1;
        }

        //設定目前的總頁數
        public void SetCurrentPageCount(int category)
        {
            _pageCount = ((_model.GetProductCount(category) - 1) / Constant.SIX) + 1;
        }

        //更新顯示商品按鈕
        public int GetAddCount(int category)
        {
            int startIndex = (_pageNumber - 1) * Constant.SIX;
            int leftCount = _model.GetProductCount(category) - ((_pageNumber - 1) * Constant.SIX);
            int addCount;
            if (leftCount < Constant.SIX)
                addCount = leftCount;
            else
                addCount = Constant.SIX;
            return addCount;
        }

        //回傳開始索引值
        public int GetStartIndex()
        {
            return (_pageNumber - 1) * Constant.SIX;
        }

        //減少商品數量
        public void ReduceProductQuantity()
        {
            for (int i = 0; i < _model.GetOrderCount(); i++)
                for (int j = 0; j < GetCategoryCount(); j++)
                    for (int k = 0; k < GetProductCount(j); k++)
                        if (_model.GetOrderProductName(i) == GetProductName(j, k))
                        {
                            _stock.SupplyProduct(j, k, GetReduceQuantity(GetQuantity(j, k), i));
                            break;
                        }
        }

        //回傳類別數量
        private int GetCategoryCount()
        {
            return _model.GetCategoryCount();
        }

        //回傳商品數量
        private int GetProductCount(int index)
        {
            return _model.GetProductCount(index);
        }

        //回傳商品名稱
        private string GetProductName(int category, int product)
        {
            return _model.GetProductName(category, product);
        }

        //取得數量
        public int GetQuantity(int category, int product)
        {
            int quantity = _model.GetProductStockQuantity(category, product);
            return quantity;
        }

        //取得要減少的數量
        public int GetReduceQuantity(int quantity, int index)
        {
            int reduceQuantity = quantity - _model.GetOrderProductQuantity(index);
            return reduceQuantity;
        }
    }
}
