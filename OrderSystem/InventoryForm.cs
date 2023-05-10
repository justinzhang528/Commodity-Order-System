using System.Drawing;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class InventoryForm : Form
    {
        InventoryFormPresentationModel _presentationModel;
        SupplementForm _supplementForm;
        Model _model;
        Stock _stock;
        private System.IO.DirectoryInfo _directory = new System.IO.DirectoryInfo(Application.StartupPath);
        public InventoryForm(Model model, Stock stock)
        {
            _model = model;
            _stock = stock;
            _presentationModel = new InventoryFormPresentationModel(_model, _stock);
            _supplementForm = new SupplementForm(_model, _stock);
            InitializeComponent();
            AddRow();
            _model._modelChanged += UpdateInventoryList;
            foreach (DataGridViewColumn column in _inventoryDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ShowProductImage(0, 0);
            _presentationModel.SetProductDescription(0, 0);
            _inventoryDataGridView.CellPainting += PaintDataGridViewCell;
            _inventoryDataGridView.CellClick += ClickInventoryDataGridViewCellHandler;
            _productIntroductionRichTextBox.DataBindings.Add("Text", _presentationModel, "ProductDescription");
        }

        //更新列表
        private void UpdateInventoryList()
        {
            _inventoryDataGridView.Rows.Clear();
            AddRow();
        }

        //為DataGridView的按鈕添加圖標
        private void PaintDataGridViewCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == Constant.FOUR)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = Properties.Resources.delete.Width;
                var height = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - height) / Constant.TWO;
                e.Graphics.DrawImage(Properties.Resources.car, new Rectangle(x, y, width, height));
                e.Handled = true;
            }
        }

        //添加庫存中的商品行
        public void AddRow()
        {
            for (int i = 0; i < _stock.GetCategoryCount(); i++)
            {
                Add(i);
            }
        }

        //添加庫存中的商品行
        public void Add(int number)
        {
            for (int j = 0; j < _model.GetProductCount(number); j++)
            {
                _inventoryDataGridView.Rows.Add(_stock.GetProductName(number, j), _stock.GetProductCategoryName(number), _stock.GetProductPrice(number, j).ToString(Constant.CHARACTER_NUMBER_SEPARATOR), _stock.GetProductStockQuantity(number, j));
            }
        }

        //顯示當前商品圖片
        public void ShowProductImage(int category, int product)
        {
            _productPicture.BackgroundImage = Image.FromFile(_directory.Parent.Parent.FullName + @"\Images\" + _stock.GetProductImagePath(category, product));
            _productPicture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //更新庫存數量顯示
        public void UpdateProductQuantityDisplay(int rowIndex)
        {
            _inventoryDataGridView.Rows[rowIndex].Cells[Constant.THREE].Value = _stock.GetProductStockQuantity(_model.CategoryNumber, _model.ProductNumber);
        }

        //點擊庫存管理列表的觸發事件
        private void ClickInventoryDataGridViewCellHandler(object sender, DataGridViewCellEventArgs e)
        {
            _model.ConvertFromIndexToProductNumber(e.RowIndex);
            if (e.RowIndex > -1)
            {
                ShowProductImage(_model.CategoryNumber, _model.ProductNumber);
                _presentationModel.SetProductDescription(_model.CategoryNumber, _model.ProductNumber);
                if (e.ColumnIndex == Constant.FOUR)
                {
                    SupplyProductEvent(e.RowIndex);
                }
            }
        }

        //更新數量顯示
        private void UpdateQuantity(int index)
        {
            _supplementForm.SetInputQuantity();
            _supplementForm.SupplyProduct();
            _supplementForm.ClearInputQuantity();
            UpdateProductQuantityDisplay(index);
            _model.UpdateProductButton();
        }

        //點擊補貨圖標的動作
        private void SupplyProductEvent(int index)
        {
            _supplementForm.SetProductDisplayDetail(_model.CategoryNumber, _model.ProductNumber);
            if (_supplementForm.ShowDialog() == DialogResult.OK)
            {
                UpdateQuantity(index);
            }
            else
            {
                _supplementForm.ClearInputQuantity();
            }
        }
    }
}
