namespace OrderSystem
{
    partial class SupplementForm
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
            this._mainLabel = new System.Windows.Forms.Label();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._productCategoryLabel = new System.Windows.Forms.Label();
            this._productPriceLabel = new System.Windows.Forms.Label();
            this._stockQuantityLabel = new System.Windows.Forms.Label();
            this._supplyQuantity = new System.Windows.Forms.Label();
            this._supplyQuantityTextBox = new System.Windows.Forms.TextBox();
            this._submitButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 3;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._mainTableLayoutPanel.Controls.Add(this._mainLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._productNameLabel, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._productCategoryLabel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._productPriceLabel, 0, 3);
            this._mainTableLayoutPanel.Controls.Add(this._stockQuantityLabel, 0, 4);
            this._mainTableLayoutPanel.Controls.Add(this._supplyQuantity, 0, 5);
            this._mainTableLayoutPanel.Controls.Add(this._supplyQuantityTextBox, 1, 5);
            this._mainTableLayoutPanel.Controls.Add(this._submitButton, 0, 6);
            this._mainTableLayoutPanel.Controls.Add(this._cancelButton, 2, 6);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 7;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(484, 395);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _mainLabel
            // 
            this._mainLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._mainLabel, 3);
            this._mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainLabel.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._mainLabel.Location = new System.Drawing.Point(3, 0);
            this._mainLabel.Name = "_mainLabel";
            this._mainLabel.Size = new System.Drawing.Size(478, 98);
            this._mainLabel.TabIndex = 0;
            this._mainLabel.Text = "補貨單";
            this._mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _productNameLabel
            // 
            this._productNameLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._productNameLabel, 3);
            this._productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productNameLabel.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._productNameLabel.Location = new System.Drawing.Point(3, 98);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._productNameLabel.Size = new System.Drawing.Size(478, 47);
            this._productNameLabel.TabIndex = 1;
            this._productNameLabel.Text = "商品名稱：";
            // 
            // _productCategoryLabel
            // 
            this._productCategoryLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._productCategoryLabel, 3);
            this._productCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productCategoryLabel.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._productCategoryLabel.Location = new System.Drawing.Point(3, 145);
            this._productCategoryLabel.Name = "_productCategoryLabel";
            this._productCategoryLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._productCategoryLabel.Size = new System.Drawing.Size(478, 47);
            this._productCategoryLabel.TabIndex = 2;
            this._productCategoryLabel.Text = "商品類別：";
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._productPriceLabel, 3);
            this._productPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productPriceLabel.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._productPriceLabel.Location = new System.Drawing.Point(3, 192);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._productPriceLabel.Size = new System.Drawing.Size(478, 47);
            this._productPriceLabel.TabIndex = 2;
            this._productPriceLabel.Text = "商品單價：";
            // 
            // _stockQuantityLabel
            // 
            this._stockQuantityLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._stockQuantityLabel, 3);
            this._stockQuantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stockQuantityLabel.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._stockQuantityLabel.Location = new System.Drawing.Point(3, 239);
            this._stockQuantityLabel.Name = "_stockQuantityLabel";
            this._stockQuantityLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._stockQuantityLabel.Size = new System.Drawing.Size(478, 47);
            this._stockQuantityLabel.TabIndex = 2;
            this._stockQuantityLabel.Text = "庫存數量：";
            // 
            // _replenishQuantity
            // 
            this._supplyQuantity.AutoSize = true;
            this._supplyQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this._supplyQuantity.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._supplyQuantity.Location = new System.Drawing.Point(3, 286);
            this._supplyQuantity.Name = "_replenishQuantity";
            this._supplyQuantity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._supplyQuantity.Size = new System.Drawing.Size(173, 47);
            this._supplyQuantity.TabIndex = 2;
            this._supplyQuantity.Text = "補貨數量：";
            // 
            // _replenishQuantityTextBox
            // 
            this._supplyQuantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._supplyQuantityTextBox.Location = new System.Drawing.Point(182, 289);
            this._supplyQuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this._supplyQuantityTextBox.Name = "_replenishQuantityTextBox";
            this._supplyQuantityTextBox.Size = new System.Drawing.Size(56, 25);
            this._supplyQuantityTextBox.TabIndex = 3;
            // 
            // _submitButton
            // 
            this._submitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._mainTableLayoutPanel.SetColumnSpan(this._submitButton, 2);
            this._submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._submitButton.Enabled = false;
            this._submitButton.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._submitButton.Location = new System.Drawing.Point(8, 341);
            this._submitButton.Margin = new System.Windows.Forms.Padding(8, 8, 10, 8);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(223, 46);
            this._submitButton.TabIndex = 4;
            this._submitButton.Text = "確認";
            this._submitButton.UseVisualStyleBackColor = false;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._cancelButton.Location = new System.Drawing.Point(251, 341);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(10, 8, 8, 8);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(225, 46);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "取消";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // ReplenishmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 395);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "ReplenishmentForm";
            this.Text = "補貨單";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _mainLabel;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.Label _productCategoryLabel;
        private System.Windows.Forms.Label _productPriceLabel;
        private System.Windows.Forms.Label _stockQuantityLabel;
        private System.Windows.Forms.Label _supplyQuantity;
        private System.Windows.Forms.TextBox _supplyQuantityTextBox;
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}