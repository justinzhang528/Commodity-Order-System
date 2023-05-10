using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class PaymentForm : Form
    {
        private PaymentFormPresentationModel _presentationModel;
        private List<TextBox> _textBoxes = new List<TextBox>();
        private List<ErrorProvider> _errorProviders = new List<ErrorProvider>();
        public PaymentForm(PaymentFormPresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            InitializeComponent();
            AddTextBoxToList();
            for (int i = 0; i < Constant.ELEVEN; i++)
            {
                _errorProviders.Add(new ErrorProvider());
            }
            for (int i = 0; i < Constant.NINE; i++)
            {
                _textBoxes[i].Leave += SetErrorProvider;
            }
            for (int i = 0; i < Constant.TWO; i++)
            {
                _textBoxes[i].KeyPress += new KeyPressEventHandler(NameHandleKeyPress);
            }
            for (int i = Constant.THREE; i < Constant.EIGHT; i++)
            {
                _textBoxes[i].KeyPress += new KeyPressEventHandler(NumberHandleKeyPress);
            }
            _submitButton.DialogResult = DialogResult.OK;
            _monthListComboBox.SelectedIndexChanged += SelectItemHandler;
            _yearListComboBox.SelectedIndexChanged += SelectItemHandler;
        }

        //限制只能输入正常的姓名字串
        private void NameHandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ((Char)Constant.EIGHT))
            {
                if (!_presentationModel.IsValidName(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                }
            }
        }

        //限制只能输入數字
        private void NumberHandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //定時觸發事件
        private void CheckTimer(object sender, EventArgs e)
        {
            for (int i = 0; i < Constant.NINE; i++)
            {
                _presentationModel.CheckFormat(_textBoxes[i].TabIndex, _textBoxes[i].Text, int.Parse(_textBoxes[i].Tag.ToString()));
                _presentationModel.SetButtonEnableStatus();
                _submitButton.Enabled = _presentationModel.IsSubmitButtonEnable();
            }
        }

        //選擇下拉式選單時所觸發的事件
        private void SelectItemHandler(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            _presentationModel.SetFormatCorrectValue(comboBox.TabIndex);
        }

        //設定警告提示
        private void SetErrorProvider(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!_presentationModel.IsFormatCorrect(textBox.TabIndex))
            {
                _errorProviders[textBox.TabIndex].SetError(textBox, "ERROR");
            }
            else
            {
                _errorProviders[textBox.TabIndex].Clear();
            }
        }

        //添加textbox到List容器中
        private void AddTextBoxToList()
        {
            _textBoxes.Add(_lastNameTextBox);
            _textBoxes.Add(_firstNameTextBox);
            _textBoxes.Add(_mailTextBox);
            _textBoxes.Add(_creditCardFirstTextBox);
            _textBoxes.Add(_creditCardSecondTextBox);
            _textBoxes.Add(_creditCardThirdTextBox);
            _textBoxes.Add(_creditCardFourthTextBox);
            _textBoxes.Add(_threeNumberSecurityCodeTextBox);
            _textBoxes.Add(_addressTextBox);
        }

        //清空信用卡背面末三碼
        public void ClearThreeNumberSecurityCode()
        {
            _threeNumberSecurityCodeTextBox.Clear();
        }
    }
}
