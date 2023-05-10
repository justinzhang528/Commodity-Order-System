
namespace OrderSystem
{
    public class MenuFormPresentationModel
    {
        bool _isOrderButtonEnable = true;
        bool _isInventoryButtonEnable = true;
        bool _isProductManageButtonEnable = true;
        //回傳訂購系統按鈕的狀態
        public bool IsOrderButtonEnable()
        {
            return _isOrderButtonEnable;
        }

        //回傳庫存系統按鈕的狀態
        public bool IsInventoryButtonEnable()
        {
            return _isInventoryButtonEnable;
        }

        //回傳庫存系統按鈕的狀態
        public bool IsProductManageButtonEnable()
        {
            return _isProductManageButtonEnable;
        }

        //按下訂單系統按鈕
        public void PressOrderButton()
        {
            _isOrderButtonEnable = false;
        }

        //按下庫存系統按鈕
        public void PressInventoryButton()
        {
            _isInventoryButtonEnable = false;
        }

        //按下商品管理系統按鈕
        public void PressProductManageButton()
        {
            _isProductManageButtonEnable = false;
        }

        //關閉訂單系統
        public void CloseOrderFormButton()
        {
            _isOrderButtonEnable = true;
        }

        //關閉庫存系統
        public void CloseInventoryFormButton()
        {
            _isInventoryButtonEnable = true;
        }

        //關閉商品管理系統
        public void CloseProductManageFormButton()
        {
            _isProductManageButtonEnable = true;
        }
    }
}
