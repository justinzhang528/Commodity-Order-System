using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderSystem
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public event ModelChangedEventHandler _modelChangedCategory;
        public delegate void ModelChangedEventHandler();
        private Stock _stock;
        private List<Order> _orders = new List<Order>();
        private List<int> _orderTotalPrice = new List<int>();
        private int _categoryNumber = 0;
        private int _productNumber = 0;
        private int _orderInputQuantity = 1;
        private int _indexToCategory = 0;
        private int _indexToProduct = 0;
        public Model(Stock stock)
        {
            _stock = stock;
        }

        //observer提示
        void NotifyObserver()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        //observer提示
        void NotifyObserverCategory()
        {
            if (_modelChangedCategory != null)
                _modelChangedCategory();
        }

        //更新庫存列表
        public void UpdateInventoryList()
        {
            NotifyObserver();
        }

        //更新商品列表
        public void UpdateProductButton()
        {
            NotifyObserver();
        }

        //更新訂單列表
        public void UpdateOrderList()
        {
            NotifyObserver();
        }

        //更新庫存列表
        public void AddNewCategoryTabPage()
        {
            NotifyObserverCategory();
        }

        //回傳商品價格
        public string GetProductImagePath(int category, int product)
        {
            return _stock.GetProductImagePath(category,product);
        }
        
        //設定商品名稱
        public string GetProductName(int category, int product)
        {
            return _stock.GetProductName(category,product);
        }

        //設定商品介紹
        public string GetProductDescription(int category, int product)
        {
            return _stock.GetProductDescription(category,product);
        }

        //設定商品庫存數量
        public int GetProductStockQuantity(int category, int product)
        {
            return _stock.GetProductStockQuantity(category,product);
        }

        //設定商品價格
        public int GetProductPrice(int category, int product)
        {
            return _stock.GetProductPrice(category, product);
        }

        //返回商品總價格
        public int GetProductTotalPrice(int index)
        {
            return _orderTotalPrice[index];
        }

        //設置商品總價格
        public void SetProductTotalPrice(int index, int totalPrice)
        {
            _orderTotalPrice[index] = totalPrice;
        }

        //設置商品數量
        public void SetOrderProductQuantity(int index, int quantity)
        {
            _orders[index].SetProductQuantity(quantity);
        }

        //設置商品名稱
        public void SetOrderProductName(int index, string name)
        {
            _orders[index].SetProductName(name);
        }

        //設置商品類別
        public void SetOrderProductCategory(int index, string category)
        {
            _orders[index].SetProductCategory(category);
        }

        //設置商品價格
        public void SetOrderProductPrice(int index, int price)
        {
            _orders[index].SetProductPrice(price);
        }

        //設置商品數量
        public int GetOrderProductQuantity(int index)
        {
            return _orders[index].GetProductQuantity();
        }

        //取得分類的數量
        public int GetCategoryCount()
        {
            return _stock.GetCategoryCount();
        }

        //取得每種分類中的商品數量
        public int GetProductCount(int category)
        {
            return _stock.GetProductCount(category);
        }

        //取得商品分類名稱
        public string GetProductCategoryName(int category)
        {
            return _stock.GetProductCategoryName(category);
        }

        //新增訂單信息到List中
        public void AddOrderInfoToList(Order order, int price)
        {
            _orders.Add(order);
            _orderTotalPrice.Add(price);
        }

        //刪除訂單中的一條信息
        public void RemoveOrderInfoFromList(int index)
        {
            _orders.RemoveAt(index);
            _orderTotalPrice.RemoveAt(index);
        }

        //清空訂單信息
        public void ClearOrderInfo()
        {
            _orders.Clear();
            _orderTotalPrice.Clear();
        }

        //計算訂單總價
        public int GetOrderTotalPrice()
        {
            int total = 0;
            foreach (var order in _orderTotalPrice)
                total += order;
            return total;
        }

        //返回總價字串
        public string GetOrderTotalPriceString()
        {
            if (GetOrderTotalPrice() == 0)
                return Constant.ZERO;
            else
                return GetOrderTotalPrice().ToString(Constant.CHARACTER_NUMBER_SEPARATOR);
        }

        //回傳訂單商品名稱
        public string GetOrderProductName(int index)
        {
            return _orders[index].GetProductName();
        }

        //回傳訂單商品價格
        public string GetOrderProductPrice(int index)
        {
            return _orders[index].GetProductPrice().ToString(Constant.CHARACTER_NUMBER_SEPARATOR);
        }

        //回傳訂單商品分類
        public string GetOrderProductCategory(int index)
        {
            return _orders[index].GetProductCategory();
        }

        //判斷字串是否為數字
        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, @"^[-+]?\d+(\.\d+)?$");
        }

        //判斷字串是否為正確的email格式
        public bool IsValidMailFormat(string text)
        {
            return Regex.IsMatch(text, @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        }

        //判斷字串是否為正常的姓名
        public bool IsValidName(string text)
        {
            return Regex.IsMatch(text, @"^[A-Za-z\u4e00-\u9fa5]+$");
        }

        //從index轉換到商品號碼
        public void ConvertFromIndexToProductNumber(int index)
        {
            int counter = 0;
            for (_categoryNumber = 0; _categoryNumber < GetCategoryCount(); _categoryNumber++)
                for (_productNumber = 0; _productNumber < GetProductCount(_categoryNumber); _productNumber++)
                {
                    if (index <= counter)
                        return;
                    counter++;
                }
        }

        //回傳商品號碼
        public int ProductNumber
        {
            get
            {
                return _productNumber;
            }
            set
            {
                _productNumber = value;
            }
            
        }

        //回傳分類號碼
        public int CategoryNumber
        {
            get
            {
                return _categoryNumber;
            }
            set
            {
                _categoryNumber = value;
            }            
        }

        //補貨
        public void SupplyProduct(int category, int product, int number)
        {
            _stock.SupplyProduct(category, product, number);
        }

        //返回訂單數量
        public int GetOrderCount()
        {
            return _orders.Count;
        }

        //回傳訂單輸入數量
        public int GetOrderInputQuantity()
        {
            return _orderInputQuantity;
        }

        //回傳商品庫存數量
        public int GetProductStockQuantity()
        {
            return _stock.GetProductStockQuantity(_indexToCategory, _indexToProduct);
        }

        //設定訂單的各種數據
        public void SetOrderInputQuantity(string text)
        {
            _orderInputQuantity = int.Parse(text);
        }

        //設定類別與商品的index
        public void SetCategoryAndProductIndex(int selectedOrderIndex)
        {
            for (int i = 0; i < GetCategoryCount(); i++)
                for (int j = 0; j < GetProductCount(i); j++)
                    if (_orders[selectedOrderIndex].GetProductName() == GetProductName(i, j))
                    {
                        _indexToCategory = i;
                        _indexToProduct = j;
                        return;
                    }
        }

        //輸入數量與庫存數量的對比
        public bool GetCompareInputQuantityAndStockQuantity()
        {
            if (_orderInputQuantity > GetProductStockQuantity(_indexToCategory, _indexToProduct))
            {
                _orderInputQuantity = GetProductStockQuantity(_indexToCategory, _indexToProduct);
                return true;
            }
            return false;
        }

        //設定訂單數量及總價
        public void SetOrderProductQuantityAndTotalPrice(int rowIndex)
        {
            SetOrderProductQuantity(rowIndex, _orderInputQuantity);
            SetProductTotalPrice(rowIndex, GetOrderProductTotalPrice());
        }

        //回傳訂單商品總價
        public int GetOrderProductTotalPrice()
        {
            return _orderInputQuantity * GetProductPrice(_indexToCategory, _indexToProduct);
        }
    }
}
