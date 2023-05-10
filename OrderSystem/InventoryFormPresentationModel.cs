using System.ComponentModel;

namespace OrderSystem
{
    public class InventoryFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Model _model;
        Stock _stock;
        string _productDescription;
        public InventoryFormPresentationModel(Model model, Stock stock)
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

        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }
        }

        //設定商品描述
        public void SetProductDescription(int category, int product)
        {
            _productDescription = _stock.GetProductDescription(category, product);
            Notify(Constant.PRODUCT_DESCRIPTION);
        }
    }
}
