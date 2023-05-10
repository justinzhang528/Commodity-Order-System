namespace OrderSystem
{
    partial class MenuForm
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
            this._menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderSystemButton = new System.Windows.Forms.Button();
            this._inventorySystemButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._productManageSystemButton = new System.Windows.Forms.Button();
            this._menuTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuTableLayoutPanel
            // 
            this._menuTableLayoutPanel.ColumnCount = 2;
            this._menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._menuTableLayoutPanel.Controls.Add(this._orderSystemButton, 0, 0);
            this._menuTableLayoutPanel.Controls.Add(this._inventorySystemButton, 0, 1);
            this._menuTableLayoutPanel.Controls.Add(this._exitButton, 1, 3);
            this._menuTableLayoutPanel.Controls.Add(this._productManageSystemButton, 0, 2);
            this._menuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._menuTableLayoutPanel.Name = "_menuTableLayoutPanel";
            this._menuTableLayoutPanel.RowCount = 4;
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this._menuTableLayoutPanel.Size = new System.Drawing.Size(610, 367);
            this._menuTableLayoutPanel.TabIndex = 0;
            // 
            // _orderSystemButton
            // 
            this._menuTableLayoutPanel.SetColumnSpan(this._orderSystemButton, 2);
            this._orderSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._orderSystemButton.Location = new System.Drawing.Point(6, 6);
            this._orderSystemButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this._orderSystemButton.Name = "_orderSystemButton";
            this._orderSystemButton.Size = new System.Drawing.Size(598, 96);
            this._orderSystemButton.TabIndex = 0;
            this._orderSystemButton.Text = "Order System";
            this._orderSystemButton.UseVisualStyleBackColor = true;
            // 
            // _inventorySystemButton
            // 
            this._menuTableLayoutPanel.SetColumnSpan(this._inventorySystemButton, 2);
            this._inventorySystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inventorySystemButton.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._inventorySystemButton.Location = new System.Drawing.Point(6, 108);
            this._inventorySystemButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this._inventorySystemButton.Name = "_inventorySystemButton";
            this._inventorySystemButton.Size = new System.Drawing.Size(598, 96);
            this._inventorySystemButton.TabIndex = 1;
            this._inventorySystemButton.Text = "Inventory System";
            this._inventorySystemButton.UseVisualStyleBackColor = true;
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(433, 312);
            this._exitButton.Margin = new System.Windows.Forms.Padding(6);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(171, 49);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            // 
            // _productManageSystemButton
            // 
            this._menuTableLayoutPanel.SetColumnSpan(this._productManageSystemButton, 2);
            this._productManageSystemButton.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._productManageSystemButton.Location = new System.Drawing.Point(6, 210);
            this._productManageSystemButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this._productManageSystemButton.Name = "_productManageSystemButton";
            this._productManageSystemButton.Size = new System.Drawing.Size(598, 96);
            this._productManageSystemButton.TabIndex = 3;
            this._productManageSystemButton.Text = "Product Manage System";
            this._productManageSystemButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 367);
            this.Controls.Add(this._menuTableLayoutPanel);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this._menuTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _menuTableLayoutPanel;
        private System.Windows.Forms.Button _orderSystemButton;
        private System.Windows.Forms.Button _inventorySystemButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _productManageSystemButton;
    }
}