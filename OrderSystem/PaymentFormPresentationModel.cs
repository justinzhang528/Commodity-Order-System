
namespace OrderSystem
{
    public class PaymentFormPresentationModel
    {
        private Model _model;
        private bool[] _isFormatCorrect = new bool[Constant.ELEVEN];
        bool _isSubmitButtonEnable = true;
        bool _isInputEnable = true;
        public PaymentFormPresentationModel(Model model)
        {
            _model = model;
            for (int i = 0; i < Constant.ELEVEN; i++)
            {
                _isFormatCorrect[i] = false;
            }
        }

        //檢查所有欄位的格式是否正確
        private bool IsAllFormatCorrect()
        {
            for (int i = 0; i < Constant.ELEVEN; i++)
            {
                if (!_isFormatCorrect[i])
                {
                    return false;
                }
            }
            return true;
        }

        //設定按鈕的開關
        public void SetButtonEnableStatus()
        {
            if (IsAllFormatCorrect())
            {
                _isSubmitButtonEnable = true;
            }
            else
            {
                _isSubmitButtonEnable = false;
            }
        }

        //回傳確認按鈕的狀態
        public bool IsSubmitButtonEnable()
        {
            return _isSubmitButtonEnable;
        }

        //設定當前欄位的格式是否為正確的
        public void SetFormatCorrectValue(int index)
        {
            _isFormatCorrect[index] = true;
        }

        //取得格式是為否正確
        public bool GetCorrectValue(int index)
        {
            return _isFormatCorrect[index];
        }

        //回傳格式正確值
        public bool IsFormatCorrect(int index)
        {
            return _isFormatCorrect[index];
        }

        //檢查格式的正確性
        public void CheckFormat(int index, string text, int tag)
        {
            if (index == 0 || index == 1)
            {
                CheckNameFormat(text, index);
            }
            if (index >= Constant.TWO && index <= Constant.SIX)
            {
                CheckIsNumber(text, tag, index);
            }
            if (index == Constant.SEVEN)
            {
                CheckMailFormat(text, index);
            }
            if (index == Constant.EIGHT)
            {
                CheckIsNullString(text, index);
            }
        }

        //檢查是否為正常的姓名格式
        public void CheckNameFormat(string text, int index)
        {
            SetFormatCorrectValue(text == "" || !_model.IsValidName(text), index);
        }

        //檢查是否為數字
        public void CheckIsNumber(string text, int length, int index)
        {
            SetFormatCorrectValue(text.Length < length || !_model.IsNumeric(text), index);
        }

        //檢查是否為正確的郵件格式
        public void CheckMailFormat(string text, int index)
        {
            SetFormatCorrectValue(text == "" || !_model.IsValidMailFormat(text), index);
        }

        //檢查是否為空字串
        public void CheckIsNullString(string text, int index)
        {
            SetFormatCorrectValue(text == "", index);
        }

        //設定錯誤提示
        private void SetFormatCorrectValue(bool flag, int index)
        {
            if (flag)
            {
                _isFormatCorrect[index] = false;
            }
            else
            {
                _isFormatCorrect[index] = true;
            }
        }

        //回傳輸入限制的值
        public bool IsInputEnable()
        {
            return _isInputEnable;
        }

        //判斷字串是否為正常的姓名
        public bool IsValidName(string text)
        {
            return _model.IsValidName(text);
        }
    }
}
