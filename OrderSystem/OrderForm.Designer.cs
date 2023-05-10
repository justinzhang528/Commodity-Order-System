namespace OrderSystem
{
    partial class OrderForm
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
            this._myOrderDataGridView = new System.Windows.Forms.DataGridView();
            this._totalPriceLabel = new System.Windows.Forms.Label();
            this._myOrderLabel = new System.Windows.Forms.Label();
            this._mainGroupBox = new System.Windows.Forms.GroupBox();
            this._productDetailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._productDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this._descriptionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._stockQuantityLabel = new System.Windows.Forms.Label();
            this._productDescription = new System.Windows.Forms.RichTextBox();
            this._priceLabel = new System.Windows.Forms.Label();
            this._addTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._previousButton = new System.Windows.Forms.Button();
            this._pageLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._productCategoryTabControl = new System.Windows.Forms.TabControl();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._myOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderButton = new System.Windows.Forms.Button();
            this._delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._myOrderDataGridView)).BeginInit();
            this._mainGroupBox.SuspendLayout();
            this._productDetailTableLayoutPanel.SuspendLayout();
            this._productDescriptionGroupBox.SuspendLayout();
            this._descriptionTableLayoutPanel.SuspendLayout();
            this._addTableLayoutPanel.SuspendLayout();
            this._mainTableLayoutPanel.SuspendLayout();
            this._myOrderTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _myOrderDataGridView
            // 
            this._myOrderDataGridView.AllowUserToAddRows = false;
            this._myOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._myOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._myOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._delete,
            this._productName,
            this._productCategory,
            this._price,
            this._quantity,
            this._totalPrice});
            this._myOrderTableLayoutPanel.SetColumnSpan(this._myOrderDataGridView, 2);
            this._myOrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._myOrderDataGridView.Location = new System.Drawing.Point(8, 54);
            this._myOrderDataGridView.Name = "_myOrderDataGridView";
            this._myOrderDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._myOrderDataGridView.RowHeadersVisible = false;
            this._myOrderDataGridView.RowTemplate.Height = 27;
            this._myOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._myOrderDataGridView.Size = new System.Drawing.Size(665, 356);
            this._myOrderDataGridView.TabIndex = 1;
            // 
            // _totalPriceLabel
            // 
            this._totalPriceLabel.AutoSize = true;
            this._totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this._totalPriceLabel.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._totalPriceLabel.Location = new System.Drawing.Point(317, 413);
            this._totalPriceLabel.Name = "_totalPriceLabel";
            this._totalPriceLabel.Size = new System.Drawing.Size(154, 63);
            this._totalPriceLabel.TabIndex = 3;
            this._totalPriceLabel.Text = "總金額: 0 元";
            this._totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _myOrderLabel
            // 
            this._myOrderLabel.AutoSize = true;
            this._myOrderTableLayoutPanel.SetColumnSpan(this._myOrderLabel, 2);
            this._myOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._myOrderLabel.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._myOrderLabel.Location = new System.Drawing.Point(8, 5);
            this._myOrderLabel.Name = "_myOrderLabel";
            this._myOrderTableLayoutPanel.SetRowSpan(this._myOrderLabel, 2);
            this._myOrderLabel.Size = new System.Drawing.Size(665, 46);
            this._myOrderLabel.TabIndex = 2;
            this._myOrderLabel.Text = "我的訂單";
            this._myOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mainGroupBox
            // 
            this._mainGroupBox.Controls.Add(this._productDetailTableLayoutPanel);
            this._mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainGroupBox.Location = new System.Drawing.Point(9, 9);
            this._mainGroupBox.Name = "_mainGroupBox";
            this._mainGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this._mainGroupBox.Size = new System.Drawing.Size(466, 481);
            this._mainGroupBox.TabIndex = 0;
            this._mainGroupBox.TabStop = false;
            this._mainGroupBox.Text = "商品";
            // 
            // _productDetailTableLayoutPanel
            // 
            this._productDetailTableLayoutPanel.ColumnCount = 1;
            this._productDetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._productDetailTableLayoutPanel.Controls.Add(this._productDescriptionGroupBox, 0, 1);
            this._productDetailTableLayoutPanel.Controls.Add(this._addTableLayoutPanel, 0, 2);
            this._productDetailTableLayoutPanel.Controls.Add(this._productCategoryTabControl, 0, 0);
            this._productDetailTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDetailTableLayoutPanel.Location = new System.Drawing.Point(10, 28);
            this._productDetailTableLayoutPanel.Name = "_productDetailTableLayoutPanel";
            this._productDetailTableLayoutPanel.RowCount = 3;
            this._productDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this._productDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._productDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this._productDetailTableLayoutPanel.Size = new System.Drawing.Size(446, 443);
            this._productDetailTableLayoutPanel.TabIndex = 0;
            // 
            // _productDescriptionGroupBox
            // 
            this._productDescriptionGroupBox.Controls.Add(this._descriptionTableLayoutPanel);
            this._productDescriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDescriptionGroupBox.Location = new System.Drawing.Point(3, 255);
            this._productDescriptionGroupBox.Name = "_productDescriptionGroupBox";
            this._productDescriptionGroupBox.Size = new System.Drawing.Size(440, 126);
            this._productDescriptionGroupBox.TabIndex = 1;
            this._productDescriptionGroupBox.TabStop = false;
            this._productDescriptionGroupBox.Text = "商品介紹";
            // 
            // _descriptionTableLayoutPanel
            // 
            this._descriptionTableLayoutPanel.ColumnCount = 2;
            this._descriptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this._descriptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._descriptionTableLayoutPanel.Controls.Add(this._stockQuantityLabel, 1, 0);
            this._descriptionTableLayoutPanel.Controls.Add(this._productDescription, 0, 0);
            this._descriptionTableLayoutPanel.Controls.Add(this._priceLabel, 1, 1);
            this._descriptionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionTableLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this._descriptionTableLayoutPanel.Name = "_descriptionTableLayoutPanel";
            this._descriptionTableLayoutPanel.RowCount = 2;
            this._descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._descriptionTableLayoutPanel.Size = new System.Drawing.Size(434, 102);
            this._descriptionTableLayoutPanel.TabIndex = 0;
            // 
            // _stockQuantityLabel
            // 
            this._stockQuantityLabel.AutoSize = true;
            this._stockQuantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stockQuantityLabel.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._stockQuantityLabel.Location = new System.Drawing.Point(285, 0);
            this._stockQuantityLabel.Name = "_stockQuantityLabel";
            this._stockQuantityLabel.Size = new System.Drawing.Size(146, 51);
            this._stockQuantityLabel.TabIndex = 5;
            this._stockQuantityLabel.Text = "庫存數量:0";
            this._stockQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _productDescription
            // 
            this._productDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDescription.Location = new System.Drawing.Point(3, 3);
            this._productDescription.Name = "_productDescription";
            this._productDescription.ReadOnly = true;
            this._descriptionTableLayoutPanel.SetRowSpan(this._productDescription, 2);
            this._productDescription.Size = new System.Drawing.Size(276, 96);
            this._productDescription.TabIndex = 0;
            this._productDescription.Text = "";
            // 
            // _priceLabel
            // 
            this._priceLabel.AutoSize = true;
            this._priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._priceLabel.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._priceLabel.Location = new System.Drawing.Point(285, 51);
            this._priceLabel.Name = "_priceLabel";
            this._priceLabel.Size = new System.Drawing.Size(146, 51);
            this._priceLabel.TabIndex = 4;
            this._priceLabel.Text = "單價:0 元";
            this._priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _addTableLayoutPanel
            // 
            this._addTableLayoutPanel.ColumnCount = 6;
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._addTableLayoutPanel.Controls.Add(this._previousButton, 1, 0);
            this._addTableLayoutPanel.Controls.Add(this._pageLabel, 0, 0);
            this._addTableLayoutPanel.Controls.Add(this._addButton, 5, 0);
            this._addTableLayoutPanel.Controls.Add(this._nextButton, 3, 0);
            this._addTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addTableLayoutPanel.Location = new System.Drawing.Point(3, 387);
            this._addTableLayoutPanel.Name = "_addTableLayoutPanel";
            this._addTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this._addTableLayoutPanel.RowCount = 1;
            this._addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._addTableLayoutPanel.Size = new System.Drawing.Size(440, 53);
            this._addTableLayoutPanel.TabIndex = 2;
            // 
            // _previousButton
            // 
            this._previousButton.BackgroundImage = global::OrderSystem.Properties.Resources.previous;
            this._previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previousButton.Enabled = false;
            this._previousButton.Location = new System.Drawing.Point(165, 13);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(60, 37);
            this._previousButton.TabIndex = 0;
            this._previousButton.Tag = "-1";
            this._previousButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._previousButton.UseVisualStyleBackColor = true;
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pageLabel.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._pageLabel.Location = new System.Drawing.Point(3, 10);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(156, 43);
            this._pageLabel.TabIndex = 1;
            this._pageLabel.Text = "Page:1/1";
            this._pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _addButton
            // 
            this._addButton.BackgroundImage = global::OrderSystem.Properties.Resources.plus;
            this._addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addButton.Enabled = false;
            this._addButton.Location = new System.Drawing.Point(376, 13);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(61, 37);
            this._addButton.TabIndex = 0;
            this._addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _nextButton
            // 
            this._nextButton.BackgroundImage = global::OrderSystem.Properties.Resources.next;
            this._nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nextButton.Location = new System.Drawing.Point(244, 13);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(60, 37);
            this._nextButton.TabIndex = 2;
            this._nextButton.Tag = "1";
            this._nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // _productCategoryTabControl
            // 
            this._productCategoryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productCategoryTabControl.Location = new System.Drawing.Point(3, 3);
            this._productCategoryTabControl.Name = "_productCategoryTabControl";
            this._productCategoryTabControl.SelectedIndex = 0;
            this._productCategoryTabControl.Size = new System.Drawing.Size(440, 246);
            this._productCategoryTabControl.TabIndex = 3;
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 3;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this._mainTableLayoutPanel.Controls.Add(this._mainGroupBox, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._myOrderTableLayoutPanel, 2, 0);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(6);
            this._mainTableLayoutPanel.RowCount = 1;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(1194, 499);
            this._mainTableLayoutPanel.TabIndex = 4;
            // 
            // _myOrderTableLayoutPanel
            // 
            this._myOrderTableLayoutPanel.ColumnCount = 2;
            this._myOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._myOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._myOrderTableLayoutPanel.Controls.Add(this._totalPriceLabel, 0, 3);
            this._myOrderTableLayoutPanel.Controls.Add(this._myOrderLabel, 0, 0);
            this._myOrderTableLayoutPanel.Controls.Add(this._myOrderDataGridView, 0, 2);
            this._myOrderTableLayoutPanel.Controls.Add(this._orderButton, 1, 3);
            this._myOrderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._myOrderTableLayoutPanel.Location = new System.Drawing.Point(504, 9);
            this._myOrderTableLayoutPanel.Name = "_myOrderTableLayoutPanel";
            this._myOrderTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this._myOrderTableLayoutPanel.RowCount = 4;
            this._myOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._myOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._myOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this._myOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this._myOrderTableLayoutPanel.Size = new System.Drawing.Size(681, 481);
            this._myOrderTableLayoutPanel.TabIndex = 1;
            // 
            // _orderButton
            // 
            this._orderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton.Enabled = false;
            this._orderButton.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._orderButton.Location = new System.Drawing.Point(484, 423);
            this._orderButton.Margin = new System.Windows.Forms.Padding(10);
            this._orderButton.Name = "_orderButton";
            this._orderButton.Size = new System.Drawing.Size(182, 43);
            this._orderButton.TabIndex = 4;
            this._orderButton.Text = "訂購";
            this._orderButton.UseVisualStyleBackColor = true;
            this._orderButton.Click += new System.EventHandler(this.OrderButtonHandler);
            // 
            // _delete
            // 
            this._delete.FillWeight = 40F;
            this._delete.HeaderText = "删除";
            this._delete.Name = "_delete";
            this._delete.ReadOnly = true;
            // 
            // _productName
            // 
            this._productName.FillWeight = 140F;
            this._productName.HeaderText = "商品名稱";
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            // 
            // _productCategory
            // 
            this._productCategory.FillWeight = 80F;
            this._productCategory.HeaderText = "商品類別";
            this._productCategory.Name = "_productCategory";
            this._productCategory.ReadOnly = true;
            // 
            // _price
            // 
            this._price.FillWeight = 60F;
            this._price.HeaderText = "單價";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            // 
            // _quantity
            // 
            this._quantity.FillWeight = 50F;
            this._quantity.HeaderText = "數量";
            this._quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._quantity.Name = "_quantity";
            this._quantity.ReadOnly = true;
            // 
            // _totalPrice
            // 
            this._totalPrice.FillWeight = 120F;
            this._totalPrice.HeaderText = "總價";
            this._totalPrice.Name = "_totalPrice";
            this._totalPrice.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 499);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "OrderForm";
            this.Text = "訂購";
            ((System.ComponentModel.ISupportInitialize)(this._myOrderDataGridView)).EndInit();
            this._mainGroupBox.ResumeLayout(false);
            this._productDetailTableLayoutPanel.ResumeLayout(false);
            this._productDescriptionGroupBox.ResumeLayout(false);
            this._descriptionTableLayoutPanel.ResumeLayout(false);
            this._descriptionTableLayoutPanel.PerformLayout();
            this._addTableLayoutPanel.ResumeLayout(false);
            this._addTableLayoutPanel.PerformLayout();
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._myOrderTableLayoutPanel.ResumeLayout(false);
            this._myOrderTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _myOrderDataGridView;
        private System.Windows.Forms.Label _totalPriceLabel;
        private System.Windows.Forms.Label _myOrderLabel;
        private System.Windows.Forms.GroupBox _mainGroupBox;
        private System.Windows.Forms.GroupBox _productDescriptionGroupBox;
        private System.Windows.Forms.Label _priceLabel;
        private System.Windows.Forms.RichTextBox _productDescription;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.TableLayoutPanel _productDetailTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _descriptionTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _myOrderTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _addTableLayoutPanel;
        private System.Windows.Forms.TabControl _productCategoryTabControl;
        private System.Windows.Forms.Button _orderButton;
        private System.Windows.Forms.Button _previousButton;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Label _stockQuantityLabel;
        private System.Windows.Forms.DataGridViewButtonColumn _delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalPrice;
    }
}

