
namespace OrderSystem
{
    public class Order
    {
        private string _productName;
        private string _productCategory;
        private int _price;
        private int _quantity;
        public Order(string productName, string productCategory, int price, int quantity)
        {
            _productName = productName;
            _productCategory = productCategory;
            _price = price;
            _quantity = quantity;
        }

        //返回商品名稱
        public string GetProductName()
        {
            return _productName;
        }

        //返回商品分類
        public string GetProductCategory()
        {
            return _productCategory;
        }

        //返回商品總價格
        public int GetProductPrice()
        {
            return _price;
        }

        //返回商品數量
        public int GetProductQuantity()
        {
            return _quantity;
        }

        //設置商品數量
        public void SetProductQuantity(int count)
        {
            _quantity = count;
        }

        //設置商品名稱
        public void SetProductName(string name)
        {
            _productName = name;
        }

        //設置商品價格
        public void SetProductPrice(int price)
        {
            _price = price;
        }

        //設置商品類別
        public void SetProductCategory(string category)
        {
            _productCategory = category;
        }
    }
}
