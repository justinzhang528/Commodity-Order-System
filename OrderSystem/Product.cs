
namespace OrderSystem
{
    public class Product
    {
        private string _name;
        private string _description;
        private int _price;
        private int _stockQuantity;
        private string _imagePath;

        public Product(string name, string description, int price, int stockQuantity, string imagePath)
        {
            _name = name;
            _description = description;
            _price = price;
            _stockQuantity = stockQuantity;
            _imagePath = imagePath;
        }

        //商品名稱
        public string Name
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

        //商品介紹
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        //商品價格
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        //商品圖片路徑
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
            }

        }

        //商品庫存數量
        public int StockQuantity
        {
            get
            {
                return _stockQuantity;
            }
            set
            {
                _stockQuantity = value;
            }

        }
    }
}
