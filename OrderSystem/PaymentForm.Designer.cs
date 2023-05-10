namespace OrderSystem
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._lastNameTextBox = new System.Windows.Forms.TextBox();
            this._creditCardPaymentLabel = new System.Windows.Forms.Label();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._firstNameTextBox = new System.Windows.Forms.TextBox();
            this._dashLabel1 = new System.Windows.Forms.Label();
            this._dashLabel2 = new System.Windows.Forms.Label();
            this._dashLabel3 = new System.Windows.Forms.Label();
            this._dashLabel4 = new System.Windows.Forms.Label();
            this._creditCardFirstTextBox = new System.Windows.Forms.TextBox();
            this._creditCardSecondTextBox = new System.Windows.Forms.TextBox();
            this._creditCardThirdTextBox = new System.Windows.Forms.TextBox();
            this._creditCardFourthTextBox = new System.Windows.Forms.TextBox();
            this._nameOfCreditCardLabel = new System.Windows.Forms.Label();
            this._creditCardNumberLabel = new System.Windows.Forms.Label();
            this._validDateLabel = new System.Windows.Forms.Label();
            this._backSideLastThreeNumberLabel = new System.Windows.Forms.Label();
            this._mailLabel = new System.Windows.Forms.Label();
            this._addressLabel = new System.Windows.Forms.Label();
            this._threeNumberSecurityCodeTextBox = new System.Windows.Forms.TextBox();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this._addressTextBox = new System.Windows.Forms.TextBox();
            this._monthListComboBox = new System.Windows.Forms.ComboBox();
            this._yearListComboBox = new System.Windows.Forms.ComboBox();
            this._submitButton = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lastNameTextBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._lastNameTextBox, 3);
            this._lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lastNameTextBox.Location = new System.Drawing.Point(13, 88);
            this._lastNameTextBox.Name = "_lastNameTextBox";
            this._lastNameTextBox.Size = new System.Drawing.Size(215, 25);
            this._lastNameTextBox.TabIndex = 0;
            this._lastNameTextBox.Tag = "0";
            // 
            // _creditCardPaymentLabel
            // 
            this._tableLayoutPanel.SetColumnSpan(this._creditCardPaymentLabel, 7);
            this._creditCardPaymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditCardPaymentLabel.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._creditCardPaymentLabel.Location = new System.Drawing.Point(13, 0);
            this._creditCardPaymentLabel.Name = "_creditCardPaymentLabel";
            this._creditCardPaymentLabel.Size = new System.Drawing.Size(470, 54);
            this._creditCardPaymentLabel.TabIndex = 0;
            this._creditCardPaymentLabel.Text = "信用卡支付";
            this._creditCardPaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 7;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661334F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661334F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661334F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this._tableLayoutPanel.Controls.Add(this._creditCardPaymentLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._lastNameTextBox, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._firstNameTextBox, 4, 2);
            this._tableLayoutPanel.Controls.Add(this._dashLabel1, 3, 2);
            this._tableLayoutPanel.Controls.Add(this._dashLabel2, 1, 4);
            this._tableLayoutPanel.Controls.Add(this._dashLabel3, 3, 4);
            this._tableLayoutPanel.Controls.Add(this._dashLabel4, 5, 4);
            this._tableLayoutPanel.Controls.Add(this._creditCardFirstTextBox, 0, 4);
            this._tableLayoutPanel.Controls.Add(this._creditCardSecondTextBox, 2, 4);
            this._tableLayoutPanel.Controls.Add(this._creditCardThirdTextBox, 4, 4);
            this._tableLayoutPanel.Controls.Add(this._creditCardFourthTextBox, 6, 4);
            this._tableLayoutPanel.Controls.Add(this._nameOfCreditCardLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._creditCardNumberLabel, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._validDateLabel, 0, 5);
            this._tableLayoutPanel.Controls.Add(this._backSideLastThreeNumberLabel, 0, 7);
            this._tableLayoutPanel.Controls.Add(this._mailLabel, 0, 9);
            this._tableLayoutPanel.Controls.Add(this._addressLabel, 0, 11);
            this._tableLayoutPanel.Controls.Add(this._threeNumberSecurityCodeTextBox, 0, 8);
            this._tableLayoutPanel.Controls.Add(this._mailTextBox, 0, 10);
            this._tableLayoutPanel.Controls.Add(this._addressTextBox, 0, 12);
            this._tableLayoutPanel.Controls.Add(this._monthListComboBox, 0, 6);
            this._tableLayoutPanel.Controls.Add(this._yearListComboBox, 4, 6);
            this._tableLayoutPanel.Controls.Add(this._submitButton, 0, 14);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._tableLayoutPanel.RowCount = 15;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00496F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.832893F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.00021F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.000111F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(496, 547);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _firstNameTextBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._firstNameTextBox, 3);
            this._firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstNameTextBox.Location = new System.Drawing.Point(265, 88);
            this._firstNameTextBox.Name = "_firstNameTextBox";
            this._firstNameTextBox.Size = new System.Drawing.Size(218, 25);
            this._firstNameTextBox.TabIndex = 1;
            this._firstNameTextBox.Tag = "0";
            // 
            // _dashLabel1
            // 
            this._dashLabel1.AutoSize = true;
            this._dashLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dashLabel1.Location = new System.Drawing.Point(234, 85);
            this._dashLabel1.Name = "_dashLabel1";
            this._dashLabel1.Size = new System.Drawing.Size(25, 31);
            this._dashLabel1.TabIndex = 3;
            this._dashLabel1.Text = "-";
            this._dashLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dashLabel2
            // 
            this._dashLabel2.AutoSize = true;
            this._dashLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dashLabel2.Location = new System.Drawing.Point(108, 147);
            this._dashLabel2.Name = "_dashLabel2";
            this._dashLabel2.Size = new System.Drawing.Size(25, 31);
            this._dashLabel2.TabIndex = 4;
            this._dashLabel2.Text = "-";
            this._dashLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dashLabel3
            // 
            this._dashLabel3.AutoSize = true;
            this._dashLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dashLabel3.Location = new System.Drawing.Point(234, 147);
            this._dashLabel3.Name = "_dashLabel3";
            this._dashLabel3.Size = new System.Drawing.Size(25, 31);
            this._dashLabel3.TabIndex = 4;
            this._dashLabel3.Text = "-";
            this._dashLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dashLabel4
            // 
            this._dashLabel4.AutoSize = true;
            this._dashLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dashLabel4.Location = new System.Drawing.Point(360, 147);
            this._dashLabel4.Name = "_dashLabel4";
            this._dashLabel4.Size = new System.Drawing.Size(25, 31);
            this._dashLabel4.TabIndex = 4;
            this._dashLabel4.Text = "-";
            this._dashLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _creditCardFirstTextBox
            // 
            this._creditCardFirstTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditCardFirstTextBox.Location = new System.Drawing.Point(13, 150);
            this._creditCardFirstTextBox.MaxLength = 4;
            this._creditCardFirstTextBox.Name = "_creditCardFirstTextBox";
            this._creditCardFirstTextBox.Size = new System.Drawing.Size(89, 25);
            this._creditCardFirstTextBox.TabIndex = 2;
            this._creditCardFirstTextBox.Tag = "4";
            // 
            // _creditCardSecondTextBox
            // 
            this._creditCardSecondTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditCardSecondTextBox.Location = new System.Drawing.Point(139, 150);
            this._creditCardSecondTextBox.MaxLength = 4;
            this._creditCardSecondTextBox.Name = "_creditCardSecondTextBox";
            this._creditCardSecondTextBox.Size = new System.Drawing.Size(89, 25);
            this._creditCardSecondTextBox.TabIndex = 3;
            this._creditCardSecondTextBox.Tag = "4";
            // 
            // _creditCardThirdTextBox
            // 
            this._creditCardThirdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditCardThirdTextBox.Location = new System.Drawing.Point(265, 150);
            this._creditCardThirdTextBox.MaxLength = 4;
            this._creditCardThirdTextBox.Name = "_creditCardThirdTextBox";
            this._creditCardThirdTextBox.Size = new System.Drawing.Size(89, 25);
            this._creditCardThirdTextBox.TabIndex = 4;
            this._creditCardThirdTextBox.Tag = "4";
            // 
            // _creditCardFourthTextBox
            // 
            this._creditCardFourthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditCardFourthTextBox.Location = new System.Drawing.Point(391, 150);
            this._creditCardFourthTextBox.MaxLength = 4;
            this._creditCardFourthTextBox.Name = "_creditCardFourthTextBox";
            this._creditCardFourthTextBox.Size = new System.Drawing.Size(92, 25);
            this._creditCardFourthTextBox.TabIndex = 5;
            this._creditCardFourthTextBox.Tag = "4";
            // 
            // _nameOfCreditCardLabel
            // 
            this._nameOfCreditCardLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._nameOfCreditCardLabel, 2);
            this._nameOfCreditCardLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._nameOfCreditCardLabel.Location = new System.Drawing.Point(13, 65);
            this._nameOfCreditCardLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._nameOfCreditCardLabel.Name = "_nameOfCreditCardLabel";
            this._nameOfCreditCardLabel.Size = new System.Drawing.Size(120, 15);
            this._nameOfCreditCardLabel.TabIndex = 9;
            this._nameOfCreditCardLabel.Text = "持卡人姓名*";
            // 
            // _creditCardNumberLabel
            // 
            this._creditCardNumberLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._creditCardNumberLabel, 2);
            this._creditCardNumberLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._creditCardNumberLabel.Location = new System.Drawing.Point(13, 127);
            this._creditCardNumberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._creditCardNumberLabel.Name = "_creditCardNumberLabel";
            this._creditCardNumberLabel.Size = new System.Drawing.Size(120, 15);
            this._creditCardNumberLabel.TabIndex = 10;
            this._creditCardNumberLabel.Text = "信用卡卡號*";
            // 
            // _validDateLabel
            // 
            this._validDateLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._validDateLabel, 3);
            this._validDateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._validDateLabel.Location = new System.Drawing.Point(13, 189);
            this._validDateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._validDateLabel.Name = "_validDateLabel";
            this._validDateLabel.Size = new System.Drawing.Size(215, 15);
            this._validDateLabel.TabIndex = 10;
            this._validDateLabel.Text = "有效日期*(月/年)";
            // 
            // _backSideLastThreeNumberLabel
            // 
            this._backSideLastThreeNumberLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._backSideLastThreeNumberLabel, 2);
            this._backSideLastThreeNumberLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._backSideLastThreeNumberLabel.Location = new System.Drawing.Point(13, 251);
            this._backSideLastThreeNumberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._backSideLastThreeNumberLabel.Name = "_backSideLastThreeNumberLabel";
            this._backSideLastThreeNumberLabel.Size = new System.Drawing.Size(120, 15);
            this._backSideLastThreeNumberLabel.TabIndex = 10;
            this._backSideLastThreeNumberLabel.Text = "背面末三碼*";
            // 
            // _mailLabel
            // 
            this._mailLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._mailLabel, 2);
            this._mailLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._mailLabel.Location = new System.Drawing.Point(13, 313);
            this._mailLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(120, 15);
            this._mailLabel.TabIndex = 10;
            this._mailLabel.Text = "Email*";
            // 
            // _addressLabel
            // 
            this._addressLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._addressLabel, 2);
            this._addressLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._addressLabel.Location = new System.Drawing.Point(13, 375);
            this._addressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(120, 15);
            this._addressLabel.TabIndex = 10;
            this._addressLabel.Text = "賬單地址*";
            // 
            // _threeNumberSecurityCodeTextBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._threeNumberSecurityCodeTextBox, 7);
            this._threeNumberSecurityCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._threeNumberSecurityCodeTextBox.Location = new System.Drawing.Point(13, 274);
            this._threeNumberSecurityCodeTextBox.MaxLength = 3;
            this._threeNumberSecurityCodeTextBox.Name = "_threeNumberSecurityCodeTextBox";
            this._threeNumberSecurityCodeTextBox.Size = new System.Drawing.Size(470, 25);
            this._threeNumberSecurityCodeTextBox.TabIndex = 6;
            this._threeNumberSecurityCodeTextBox.Tag = "3";
            // 
            // _mailTextBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._mailTextBox, 7);
            this._mailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailTextBox.Location = new System.Drawing.Point(13, 336);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(470, 25);
            this._mailTextBox.TabIndex = 7;
            this._mailTextBox.Tag = "0";
            // 
            // _addressTextBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._addressTextBox, 7);
            this._addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressTextBox.Location = new System.Drawing.Point(13, 398);
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(470, 25);
            this._addressTextBox.TabIndex = 8;
            this._addressTextBox.Tag = "0";
            // 
            // _monthListComboBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._monthListComboBox, 3);
            this._monthListComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._monthListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._monthListComboBox.FormattingEnabled = true;
            this._monthListComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this._monthListComboBox.Location = new System.Drawing.Point(13, 212);
            this._monthListComboBox.Name = "_monthListComboBox";
            this._monthListComboBox.Size = new System.Drawing.Size(215, 23);
            this._monthListComboBox.TabIndex = 9;
            // 
            // _yearListComboBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._yearListComboBox, 3);
            this._yearListComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._yearListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._yearListComboBox.FormattingEnabled = true;
            this._yearListComboBox.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this._yearListComboBox.Location = new System.Drawing.Point(265, 212);
            this._yearListComboBox.Name = "_yearListComboBox";
            this._yearListComboBox.Size = new System.Drawing.Size(218, 23);
            this._yearListComboBox.TabIndex = 10;
            // 
            // _submitButton
            // 
            this._submitButton.BackColor = System.Drawing.Color.Red;
            this._tableLayoutPanel.SetColumnSpan(this._submitButton, 7);
            this._submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._submitButton.Enabled = false;
            this._submitButton.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._submitButton.Location = new System.Drawing.Point(13, 500);
            this._submitButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(470, 35);
            this._submitButton.TabIndex = 16;
            this._submitButton.Text = "確認";
            this._submitButton.UseVisualStyleBackColor = false;
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Tick += new System.EventHandler(this.CheckTimer);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 547);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "PaymentForm";
            this.Text = "CreditCardPaymentForm";
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _lastNameTextBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _creditCardPaymentLabel;
        private System.Windows.Forms.TextBox _firstNameTextBox;
        private System.Windows.Forms.Label _dashLabel1;
        private System.Windows.Forms.Label _dashLabel2;
        private System.Windows.Forms.Label _dashLabel3;
        private System.Windows.Forms.Label _dashLabel4;
        private System.Windows.Forms.TextBox _creditCardFirstTextBox;
        private System.Windows.Forms.TextBox _creditCardSecondTextBox;
        private System.Windows.Forms.TextBox _creditCardThirdTextBox;
        private System.Windows.Forms.TextBox _creditCardFourthTextBox;
        private System.Windows.Forms.Label _nameOfCreditCardLabel;
        private System.Windows.Forms.Label _creditCardNumberLabel;
        private System.Windows.Forms.Label _validDateLabel;
        private System.Windows.Forms.Label _backSideLastThreeNumberLabel;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.Label _addressLabel;
        private System.Windows.Forms.TextBox _threeNumberSecurityCodeTextBox;
        private System.Windows.Forms.TextBox _mailTextBox;
        private System.Windows.Forms.TextBox _addressTextBox;
        private System.Windows.Forms.ComboBox _monthListComboBox;
        private System.Windows.Forms.ComboBox _yearListComboBox;
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.Timer _timer;
    }
}