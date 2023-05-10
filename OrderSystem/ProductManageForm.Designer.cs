namespace OrderSystem
{
    partial class ProductManageForm
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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._productManageSystemLabel = new System.Windows.Forms.Label();
            this._productManageTabControl = new System.Windows.Forms.TabControl();
            this._productManageTabPage = new System.Windows.Forms.TabPage();
            this._productTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._productListBox = new System.Windows.Forms.ListBox();
            this._newProductButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._productDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this._productCategoryLabel = new System.Windows.Forms.Label();
            this._currencyLabel = new System.Windows.Forms.Label();
            this._productImagePathTextBox = new System.Windows.Forms.TextBox();
            this._productPriceTextBox = new System.Windows.Forms.TextBox();
            this._productNameTextBox = new System.Windows.Forms.TextBox();
            this._productIntroductionLabel = new System.Windows.Forms.Label();
            this._productIntroductionRichBox = new System.Windows.Forms.RichTextBox();
            this._productImagePathLabel = new System.Windows.Forms.Label();
            this._productPriceLabel = new System.Windows.Forms.Label();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._categoryManageTabPage = new System.Windows.Forms.TabPage();
            this._categoryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._newCategoryButton = new System.Windows.Forms.Button();
            this._newButton = new System.Windows.Forms.Button();
            this._categoryDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._categoryNameTextBox = new System.Windows.Forms.TextBox();
            this._productInCategoryLabel = new System.Windows.Forms.Label();
            this._productListRichTextBox = new System.Windows.Forms.RichTextBox();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._mainTableLayoutPanel.SuspendLayout();
            this._productManageTabControl.SuspendLayout();
            this._productManageTabPage.SuspendLayout();
            this._productTableLayoutPanel.SuspendLayout();
            this._productDetailGroupBox.SuspendLayout();
            this._categoryManageTabPage.SuspendLayout();
            this._categoryTableLayoutPanel.SuspendLayout();
            this._categoryDetailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._productManageSystemLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._productManageTabControl, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 2;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(899, 627);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _productManageSystemLabel
            // 
            this._productManageSystemLabel.AutoSize = true;
            this._productManageSystemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productManageSystemLabel.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._productManageSystemLabel.Location = new System.Drawing.Point(3, 0);
            this._productManageSystemLabel.Name = "_productManageSystemLabel";
            this._productManageSystemLabel.Size = new System.Drawing.Size(893, 75);
            this._productManageSystemLabel.TabIndex = 0;
            this._productManageSystemLabel.Text = "商品管理系統";
            this._productManageSystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _productManageTabControl
            // 
            this._productManageTabControl.Controls.Add(this._productManageTabPage);
            this._productManageTabControl.Controls.Add(this._categoryManageTabPage);
            this._productManageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productManageTabControl.Location = new System.Drawing.Point(3, 78);
            this._productManageTabControl.Name = "_productManageTabControl";
            this._productManageTabControl.SelectedIndex = 0;
            this._productManageTabControl.Size = new System.Drawing.Size(893, 546);
            this._productManageTabControl.TabIndex = 1;
            // 
            // _productManageTabPage
            // 
            this._productManageTabPage.Controls.Add(this._productTableLayoutPanel);
            this._productManageTabPage.Location = new System.Drawing.Point(4, 25);
            this._productManageTabPage.Name = "_productManageTabPage";
            this._productManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._productManageTabPage.Size = new System.Drawing.Size(885, 517);
            this._productManageTabPage.TabIndex = 0;
            this._productManageTabPage.Text = "商品管理";
            this._productManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _productTableLayoutPanel
            // 
            this._productTableLayoutPanel.ColumnCount = 3;
            this._productTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this._productTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769F));
            this._productTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this._productTableLayoutPanel.Controls.Add(this._productListBox, 0, 0);
            this._productTableLayoutPanel.Controls.Add(this._newProductButton, 0, 1);
            this._productTableLayoutPanel.Controls.Add(this._saveButton, 2, 1);
            this._productTableLayoutPanel.Controls.Add(this._productDetailGroupBox, 1, 0);
            this._productTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._productTableLayoutPanel.Name = "_productTableLayoutPanel";
            this._productTableLayoutPanel.RowCount = 2;
            this._productTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._productTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._productTableLayoutPanel.Size = new System.Drawing.Size(879, 511);
            this._productTableLayoutPanel.TabIndex = 0;
            // 
            // _productListBox
            // 
            this._productListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productListBox.FormattingEnabled = true;
            this._productListBox.ItemHeight = 15;
            this._productListBox.Location = new System.Drawing.Point(3, 3);
            this._productListBox.Name = "_productListBox";
            this._productListBox.Size = new System.Drawing.Size(264, 453);
            this._productListBox.TabIndex = 0;
            // 
            // _newProductButton
            // 
            this._newProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newProductButton.Location = new System.Drawing.Point(3, 462);
            this._newProductButton.Name = "_newProductButton";
            this._newProductButton.Size = new System.Drawing.Size(264, 46);
            this._newProductButton.TabIndex = 1;
            this._newProductButton.Text = "新增商品";
            this._newProductButton.UseVisualStyleBackColor = true;
            // 
            // _saveButton
            // 
            this._saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saveButton.Location = new System.Drawing.Point(754, 462);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(122, 46);
            this._saveButton.TabIndex = 2;
            this._saveButton.Text = "儲存";
            this._saveButton.UseVisualStyleBackColor = true;
            // 
            // _productDetailGroupBox
            // 
            this._productTableLayoutPanel.SetColumnSpan(this._productDetailGroupBox, 2);
            this._productDetailGroupBox.Controls.Add(this._browseButton);
            this._productDetailGroupBox.Controls.Add(this._productCategoryComboBox);
            this._productDetailGroupBox.Controls.Add(this._productCategoryLabel);
            this._productDetailGroupBox.Controls.Add(this._currencyLabel);
            this._productDetailGroupBox.Controls.Add(this._productImagePathTextBox);
            this._productDetailGroupBox.Controls.Add(this._productPriceTextBox);
            this._productDetailGroupBox.Controls.Add(this._productNameTextBox);
            this._productDetailGroupBox.Controls.Add(this._productIntroductionLabel);
            this._productDetailGroupBox.Controls.Add(this._productIntroductionRichBox);
            this._productDetailGroupBox.Controls.Add(this._productImagePathLabel);
            this._productDetailGroupBox.Controls.Add(this._productPriceLabel);
            this._productDetailGroupBox.Controls.Add(this._productNameLabel);
            this._productDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDetailGroupBox.Location = new System.Drawing.Point(273, 3);
            this._productDetailGroupBox.Name = "_productDetailGroupBox";
            this._productDetailGroupBox.Size = new System.Drawing.Size(603, 453);
            this._productDetailGroupBox.TabIndex = 3;
            this._productDetailGroupBox.TabStop = false;
            this._productDetailGroupBox.Text = "編輯商品";
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(491, 139);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(106, 25);
            this._browseButton.TabIndex = 11;
            this._browseButton.Text = "瀏覽...";
            this._browseButton.UseVisualStyleBackColor = true;
            // 
            // _productCategoryComboBox
            // 
            this._productCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._productCategoryComboBox.FormattingEnabled = true;
            this._productCategoryComboBox.Items.AddRange(new object[] {
            "主機板",
            "CPU",
            "記憶體",
            "硬碟",
            "顯示卡",
            "套裝電腦"});
            this._productCategoryComboBox.Location = new System.Drawing.Point(414, 92);
            this._productCategoryComboBox.Name = "_productCategoryComboBox";
            this._productCategoryComboBox.Size = new System.Drawing.Size(183, 23);
            this._productCategoryComboBox.TabIndex = 10;
            // 
            // _productCategoryLabel
            // 
            this._productCategoryLabel.AutoSize = true;
            this._productCategoryLabel.Location = new System.Drawing.Point(316, 96);
            this._productCategoryLabel.Name = "_productCategoryLabel";
            this._productCategoryLabel.Size = new System.Drawing.Size(91, 15);
            this._productCategoryLabel.TabIndex = 9;
            this._productCategoryLabel.Text = "商品類別(*)";
            // 
            // _currencyLabel
            // 
            this._currencyLabel.AutoSize = true;
            this._currencyLabel.Location = new System.Drawing.Point(245, 96);
            this._currencyLabel.Name = "_currencyLabel";
            this._currencyLabel.Size = new System.Drawing.Size(31, 15);
            this._currencyLabel.TabIndex = 8;
            this._currencyLabel.Text = "NTD";
            // 
            // _productImagePathTextBox
            // 
            this._productImagePathTextBox.Location = new System.Drawing.Point(133, 139);
            this._productImagePathTextBox.Name = "_productImagePathTextBox";
            this._productImagePathTextBox.ReadOnly = true;
            this._productImagePathTextBox.Size = new System.Drawing.Size(352, 25);
            this._productImagePathTextBox.TabIndex = 7;
            // 
            // _productPriceTextBox
            // 
            this._productPriceTextBox.Location = new System.Drawing.Point(103, 92);
            this._productPriceTextBox.Name = "_productPriceTextBox";
            this._productPriceTextBox.Size = new System.Drawing.Size(141, 25);
            this._productPriceTextBox.TabIndex = 6;
            this._productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _productNameTextBox
            // 
            this._productNameTextBox.Location = new System.Drawing.Point(103, 44);
            this._productNameTextBox.Name = "_productNameTextBox";
            this._productNameTextBox.Size = new System.Drawing.Size(494, 25);
            this._productNameTextBox.TabIndex = 5;
            // 
            // _productIntroductionLabel
            // 
            this._productIntroductionLabel.AutoSize = true;
            this._productIntroductionLabel.Location = new System.Drawing.Point(6, 194);
            this._productIntroductionLabel.Name = "_productIntroductionLabel";
            this._productIntroductionLabel.Size = new System.Drawing.Size(67, 15);
            this._productIntroductionLabel.TabIndex = 4;
            this._productIntroductionLabel.Text = "商品介紹";
            // 
            // _productIntroductionRichBox
            // 
            this._productIntroductionRichBox.Location = new System.Drawing.Point(9, 220);
            this._productIntroductionRichBox.Name = "_productIntroductionRichBox";
            this._productIntroductionRichBox.Size = new System.Drawing.Size(588, 227);
            this._productIntroductionRichBox.TabIndex = 3;
            this._productIntroductionRichBox.Text = "";
            // 
            // _productImagePathLabel
            // 
            this._productImagePathLabel.AutoSize = true;
            this._productImagePathLabel.Location = new System.Drawing.Point(6, 144);
            this._productImagePathLabel.Name = "_productImagePathLabel";
            this._productImagePathLabel.Size = new System.Drawing.Size(121, 15);
            this._productImagePathLabel.TabIndex = 2;
            this._productImagePathLabel.Text = "商品圖片路徑(*)";
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._productPriceLabel.Location = new System.Drawing.Point(6, 97);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Size = new System.Drawing.Size(91, 15);
            this._productPriceLabel.TabIndex = 1;
            this._productPriceLabel.Text = "商品價格(*)";
            // 
            // _productNameLabel
            // 
            this._productNameLabel.AutoSize = true;
            this._productNameLabel.Location = new System.Drawing.Point(6, 48);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Size = new System.Drawing.Size(91, 15);
            this._productNameLabel.TabIndex = 0;
            this._productNameLabel.Text = "商品名稱(*)";
            // 
            // _categoryManageTabPage
            // 
            this._categoryManageTabPage.Controls.Add(this._categoryTableLayoutPanel);
            this._categoryManageTabPage.Location = new System.Drawing.Point(4, 25);
            this._categoryManageTabPage.Name = "_categoryManageTabPage";
            this._categoryManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._categoryManageTabPage.Size = new System.Drawing.Size(885, 517);
            this._categoryManageTabPage.TabIndex = 1;
            this._categoryManageTabPage.Text = "類別管理";
            this._categoryManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _categoryTableLayoutPanel
            // 
            this._categoryTableLayoutPanel.ColumnCount = 3;
            this._categoryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this._categoryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769F));
            this._categoryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this._categoryTableLayoutPanel.Controls.Add(this._categoryListBox, 0, 0);
            this._categoryTableLayoutPanel.Controls.Add(this._newCategoryButton, 0, 1);
            this._categoryTableLayoutPanel.Controls.Add(this._newButton, 2, 1);
            this._categoryTableLayoutPanel.Controls.Add(this._categoryDetailGroupBox, 1, 0);
            this._categoryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._categoryTableLayoutPanel.Name = "_categoryTableLayoutPanel";
            this._categoryTableLayoutPanel.RowCount = 2;
            this._categoryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._categoryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._categoryTableLayoutPanel.Size = new System.Drawing.Size(879, 511);
            this._categoryTableLayoutPanel.TabIndex = 1;
            // 
            // _categoryListBox
            // 
            this._categoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.ItemHeight = 15;
            this._categoryListBox.Location = new System.Drawing.Point(3, 3);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(264, 453);
            this._categoryListBox.TabIndex = 0;
            // 
            // _newCategoryButton
            // 
            this._newCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newCategoryButton.Location = new System.Drawing.Point(3, 462);
            this._newCategoryButton.Name = "_newCategoryButton";
            this._newCategoryButton.Size = new System.Drawing.Size(264, 46);
            this._newCategoryButton.TabIndex = 1;
            this._newCategoryButton.Text = "新增商品";
            this._newCategoryButton.UseVisualStyleBackColor = true;
            // 
            // _newButton
            // 
            this._newButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newButton.Location = new System.Drawing.Point(754, 462);
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(122, 46);
            this._newButton.TabIndex = 2;
            this._newButton.Text = "新增";
            this._newButton.UseVisualStyleBackColor = true;
            // 
            // _categoryDetailGroupBox
            // 
            this._categoryTableLayoutPanel.SetColumnSpan(this._categoryDetailGroupBox, 2);
            this._categoryDetailGroupBox.Controls.Add(this._categoryNameTextBox);
            this._categoryDetailGroupBox.Controls.Add(this._productInCategoryLabel);
            this._categoryDetailGroupBox.Controls.Add(this._productListRichTextBox);
            this._categoryDetailGroupBox.Controls.Add(this._categoryNameLabel);
            this._categoryDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryDetailGroupBox.Location = new System.Drawing.Point(273, 3);
            this._categoryDetailGroupBox.Name = "_categoryDetailGroupBox";
            this._categoryDetailGroupBox.Size = new System.Drawing.Size(603, 453);
            this._categoryDetailGroupBox.TabIndex = 3;
            this._categoryDetailGroupBox.TabStop = false;
            this._categoryDetailGroupBox.Text = "類別";
            // 
            // _categoryNameTextBox
            // 
            this._categoryNameTextBox.Location = new System.Drawing.Point(103, 52);
            this._categoryNameTextBox.Name = "_categoryNameTextBox";
            this._categoryNameTextBox.Size = new System.Drawing.Size(494, 25);
            this._categoryNameTextBox.TabIndex = 5;
            // 
            // _productInCategoryLabel
            // 
            this._productInCategoryLabel.AutoSize = true;
            this._productInCategoryLabel.Location = new System.Drawing.Point(6, 131);
            this._productInCategoryLabel.Name = "_productInCategoryLabel";
            this._productInCategoryLabel.Size = new System.Drawing.Size(82, 15);
            this._productInCategoryLabel.TabIndex = 4;
            this._productInCategoryLabel.Text = "類別內產品";
            // 
            // _productListRichTextBox
            // 
            this._productListRichTextBox.Location = new System.Drawing.Point(9, 153);
            this._productListRichTextBox.Name = "_productListRichTextBox";
            this._productListRichTextBox.ReadOnly = true;
            this._productListRichTextBox.Size = new System.Drawing.Size(588, 294);
            this._productListRichTextBox.TabIndex = 3;
            this._productListRichTextBox.Text = "";
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Location = new System.Drawing.Point(6, 56);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(91, 15);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "類別名稱(*)";
            // 
            // ProductManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 627);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "ProductManageForm";
            this.Text = "ProductManageForm";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._mainTableLayoutPanel.PerformLayout();
            this._productManageTabControl.ResumeLayout(false);
            this._productManageTabPage.ResumeLayout(false);
            this._productTableLayoutPanel.ResumeLayout(false);
            this._productDetailGroupBox.ResumeLayout(false);
            this._productDetailGroupBox.PerformLayout();
            this._categoryManageTabPage.ResumeLayout(false);
            this._categoryTableLayoutPanel.ResumeLayout(false);
            this._categoryDetailGroupBox.ResumeLayout(false);
            this._categoryDetailGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _productManageSystemLabel;
        private System.Windows.Forms.TabControl _productManageTabControl;
        private System.Windows.Forms.TabPage _productManageTabPage;
        private System.Windows.Forms.TabPage _categoryManageTabPage;
        private System.Windows.Forms.TableLayoutPanel _productTableLayoutPanel;
        private System.Windows.Forms.ListBox _productListBox;
        private System.Windows.Forms.Button _newProductButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.GroupBox _productDetailGroupBox;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.Label _productImagePathLabel;
        private System.Windows.Forms.Label _productPriceLabel;
        private System.Windows.Forms.Label _productIntroductionLabel;
        private System.Windows.Forms.RichTextBox _productIntroductionRichBox;
        private System.Windows.Forms.Label _productCategoryLabel;
        private System.Windows.Forms.Label _currencyLabel;
        private System.Windows.Forms.TextBox _productImagePathTextBox;
        private System.Windows.Forms.TextBox _productPriceTextBox;
        private System.Windows.Forms.TextBox _productNameTextBox;
        private System.Windows.Forms.ComboBox _productCategoryComboBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.TableLayoutPanel _categoryTableLayoutPanel;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.Button _newCategoryButton;
        private System.Windows.Forms.Button _newButton;
        private System.Windows.Forms.GroupBox _categoryDetailGroupBox;
        private System.Windows.Forms.TextBox _categoryNameTextBox;
        private System.Windows.Forms.Label _productInCategoryLabel;
        private System.Windows.Forms.RichTextBox _productListRichTextBox;
        private System.Windows.Forms.Label _categoryNameLabel;
    }
}