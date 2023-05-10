using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OrderSystem
{
    public class SupplementFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Model _model;
        Stock _stock;
        bool _isSubmitButtonEnable = false;
        int _inputQuantity = 0;
        public SupplementFormPresentationModel(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
        }

        //回傳確認按鈕狀態
        public bool IsSubmitButtonEnable()
        {
            return _isSubmitButtonEnable;
        }

        //判斷是否為字串
        public void IsNullString(string text)
        {
            if (text == "")
            {
                _isSubmitButtonEnable = false;
            }
            else
            {
                _isSubmitButtonEnable = true;
            }
        }

        //設定輸入數量
        public void SetInputQuantity(int count)
        {
            _inputQuantity = count;
        }

        //回傳輸入數量
        public int GetInputQuantity()
        {
            return _inputQuantity;
        }

        //補貨
        public void Supplement(int category, int product)
        {
            _model.SupplyProduct(category, product, _inputQuantity + _stock.GetProductStockQuantity(category, product));

        }
    }
}
