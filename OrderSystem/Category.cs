using System.ComponentModel;

namespace OrderSystem
{
    public class Category
    {
        private string _name;
        private BindingList<Product> _productList = new BindingList<Product>();

        public Category(string name)
        {
            _name = name;
        }
        public string CategoryName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //新增商品
        public void AddNewProduct(Product product)
        {
            _productList.Add(product);
        }

        //移除商品
        public void RemoveProduct(int index)
        {
            _productList.RemoveAt(index);
        }

        //取得商品名稱
        public string GetProductName(int index)
        {
            return _productList[index].Name;
        }

        //取得商品分類
        public string GetProductDescription(int index)
        {
            return _productList[index].Description;
        }

        //取得商品價格
        public int GetProductPrice(int index)
        {
            return _productList[index].Price;
        }

        //取得商品庫存數量
        public int GetProductStockQuantity(int index)
        {
            return _productList[index].StockQuantity;
        }

        //取得商品圖片路徑
        public string GetProductImagePath(int index)
        {
            return _productList[index].ImagePath;
        }

        //設定商品名稱
        public void SetProductName(int index, string name)
        {
            _productList[index].Name = name;
        }

        //設定商品分類名稱
        public void SetProductCategory(string name)
        {
            _name = name;
        }

        //設定商品介紹
        public void SetProductDescription(int index, string description)
        {
            _productList[index].Description = description;
        }

        //設定商品價格
        public void SetProductPrice(int index, int price)
        {
            _productList[index].Price = price;
        }

        //設定商品庫存數量
        public void SetProductStockQuantity(int index, int quantity)
        {
            _productList[index].StockQuantity = quantity;
        }

        //設定商品圖片路徑
        public void SetProductImagePath(int index, string path)
        {
            _productList[index].ImagePath = path;
        }

        public int ProductCount
        {
            get
            {
                return _productList.Count;
            }
        }
    }
}
