namespace OrderSystem
{
    partial class InventoryForm
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
            this._headLabel = new System.Windows.Forms.Label();
            this._productPictureLabel = new System.Windows.Forms.Label();
            this._productPicture = new System.Windows.Forms.PictureBox();
            this._productIntroductionLabel = new System.Windows.Forms.Label();
            this._productIntroductionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._supplement = new System.Windows.Forms.DataGridViewButtonColumn();
            this._mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this._mainTableLayoutPanel.ColumnCount = 2;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._mainTableLayoutPanel.Controls.Add(this._headLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._productPictureLabel, 1, 1);
            this._mainTableLayoutPanel.Controls.Add(this._productPicture, 1, 2);
            this._mainTableLayoutPanel.Controls.Add(this._productIntroductionLabel, 1, 3);
            this._mainTableLayoutPanel.Controls.Add(this._productIntroductionRichTextBox, 1, 4);
            this._mainTableLayoutPanel.Controls.Add(this._inventoryDataGridView, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this._mainTableLayoutPanel.RowCount = 5;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(924, 593);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _headLabel
            // 
            this._headLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._headLabel, 2);
            this._headLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._headLabel.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._headLabel.Location = new System.Drawing.Point(8, 5);
            this._headLabel.Name = "_headLabel";
            this._headLabel.Size = new System.Drawing.Size(908, 52);
            this._headLabel.TabIndex = 0;
            this._headLabel.Text = "庫存管理系統";
            this._headLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _productPictureLabel
            // 
            this._productPictureLabel.AutoSize = true;
            this._productPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productPictureLabel.Location = new System.Drawing.Point(654, 57);
            this._productPictureLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this._productPictureLabel.Name = "_productPictureLabel";
            this._productPictureLabel.Size = new System.Drawing.Size(262, 40);
            this._productPictureLabel.TabIndex = 1;
            this._productPictureLabel.Text = "商品圖片：";
            this._productPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _productPicture
            // 
            this._productPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productPicture.Location = new System.Drawing.Point(654, 100);
            this._productPicture.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this._productPicture.Name = "_productPicture";
            this._productPicture.Size = new System.Drawing.Size(262, 192);
            this._productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._productPicture.TabIndex = 2;
            this._productPicture.TabStop = false;
            // 
            // _productIntroductionLabel
            // 
            this._productIntroductionLabel.AutoSize = true;
            this._productIntroductionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productIntroductionLabel.Location = new System.Drawing.Point(654, 295);
            this._productIntroductionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this._productIntroductionLabel.Name = "_productIntroductionLabel";
            this._productIntroductionLabel.Size = new System.Drawing.Size(262, 40);
            this._productIntroductionLabel.TabIndex = 3;
            this._productIntroductionLabel.Text = "商品介紹：";
            this._productIntroductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _productIntroductionRichTextBox
            // 
            this._productIntroductionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productIntroductionRichTextBox.Location = new System.Drawing.Point(654, 338);
            this._productIntroductionRichTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this._productIntroductionRichTextBox.Name = "_productIntroductionRichTextBox";
            this._productIntroductionRichTextBox.ReadOnly = true;
            this._productIntroductionRichTextBox.Size = new System.Drawing.Size(262, 247);
            this._productIntroductionRichTextBox.TabIndex = 4;
            this._productIntroductionRichTextBox.Text = "";
            // 
            // _inventoryDataGridView
            // 
            this._inventoryDataGridView.AllowUserToAddRows = false;
            this._inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productName,
            this._productCategory,
            this._price,
            this._quantity,
            this._supplement});
            this._inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inventoryDataGridView.Location = new System.Drawing.Point(8, 60);
            this._inventoryDataGridView.Name = "_inventoryDataGridView";
            this._inventoryDataGridView.ReadOnly = true;
            this._inventoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._inventoryDataGridView.RowHeadersVisible = false;
            this._mainTableLayoutPanel.SetRowSpan(this._inventoryDataGridView, 4);
            this._inventoryDataGridView.RowTemplate.Height = 27;
            this._inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._inventoryDataGridView.Size = new System.Drawing.Size(633, 525);
            this._inventoryDataGridView.TabIndex = 5;
            // 
            // _productName
            // 
            this._productName.FillWeight = 150F;
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
            this._price.FillWeight = 70F;
            this._price.HeaderText = "單價";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            // 
            // _quantity
            // 
            this._quantity.FillWeight = 60F;
            this._quantity.HeaderText = "數量";
            this._quantity.Name = "_quantity";
            this._quantity.ReadOnly = true;
            // 
            // _supplement
            // 
            this._supplement.FillWeight = 50F;
            this._supplement.HeaderText = "補貨";
            this._supplement.Name = "_supplement";
            this._supplement.ReadOnly = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 593);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "InventoryForm";
            this.Text = "庫存管理系統";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _headLabel;
        private System.Windows.Forms.Label _productPictureLabel;
        private System.Windows.Forms.PictureBox _productPicture;
        private System.Windows.Forms.Label _productIntroductionLabel;
        private System.Windows.Forms.RichTextBox _productIntroductionRichTextBox;
        private System.Windows.Forms.DataGridView _inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantity;
        private System.Windows.Forms.DataGridViewButtonColumn _supplement;
    }
}