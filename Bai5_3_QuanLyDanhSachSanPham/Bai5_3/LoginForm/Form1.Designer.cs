namespace LoginForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpProductInfo;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private ComboBox cboCategory;
        private GroupBox grpFunction;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private Button btnClear;
        private DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpProductInfo = new GroupBox();
            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            cboCategory = new ComboBox();
            grpFunction = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            grpProductInfo.SuspendLayout();
            grpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();

            grpProductInfo.Text = "Thông tin sản phẩm";
            grpProductInfo.Location = new Point(20, 20);
            grpProductInfo.Size = new Size(390, 250);

            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(20, 35);
            lblProductId.Text = "Mã SP:";
            txtProductId.Location = new Point(120, 32);
            txtProductId.Size = new Size(240, 27);

            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(20, 75);
            lblProductName.Text = "Tên SP:";
            txtProductName.Location = new Point(120, 72);
            txtProductName.Size = new Size(240, 27);

            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 115);
            lblUnitPrice.Text = "Đơn giá:";
            txtUnitPrice.Location = new Point(120, 112);
            txtUnitPrice.Size = new Size(240, 27);

            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 155);
            lblQuantity.Text = "Số lượng:";
            txtQuantity.Location = new Point(120, 152);
            txtQuantity.Size = new Size(240, 27);

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 195);
            lblCategory.Text = "Danh mục:";
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Laptop", "Điện thoại", "Phụ kiện" });
            cboCategory.Location = new Point(120, 192);
            cboCategory.Size = new Size(240, 28);

            grpProductInfo.Controls.Add(lblProductId);
            grpProductInfo.Controls.Add(txtProductId);
            grpProductInfo.Controls.Add(lblProductName);
            grpProductInfo.Controls.Add(txtProductName);
            grpProductInfo.Controls.Add(lblUnitPrice);
            grpProductInfo.Controls.Add(txtUnitPrice);
            grpProductInfo.Controls.Add(lblQuantity);
            grpProductInfo.Controls.Add(txtQuantity);
            grpProductInfo.Controls.Add(lblCategory);
            grpProductInfo.Controls.Add(cboCategory);

            grpFunction.Text = "Chức năng";
            grpFunction.Location = new Point(430, 20);
            grpFunction.Size = new Size(630, 250);

            btnAdd.Location = new Point(25, 35);
            btnAdd.Size = new Size(100, 38);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;

            btnEdit.Location = new Point(140, 35);
            btnEdit.Size = new Size(100, 38);
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;

            btnDelete.Location = new Point(255, 35);
            btnDelete.Size = new Size(100, 38);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;

            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(25, 105);
            lblSearch.Text = "Tìm theo tên SP:";
            txtSearch.Location = new Point(25, 135);
            txtSearch.Size = new Size(330, 27);

            btnSearch.Location = new Point(370, 132);
            btnSearch.Size = new Size(100, 34);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;

            btnClearSearch.Location = new Point(480, 132);
            btnClearSearch.Size = new Size(120, 34);
            btnClearSearch.Text = "Hiện tất cả";
            btnClearSearch.Click += btnClearSearch_Click;

            btnClear.Location = new Point(370, 35);
            btnClear.Size = new Size(100, 38);
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;

            grpFunction.Controls.Add(btnAdd);
            grpFunction.Controls.Add(btnEdit);
            grpFunction.Controls.Add(btnDelete);
            grpFunction.Controls.Add(btnClear);
            grpFunction.Controls.Add(lblSearch);
            grpFunction.Controls.Add(txtSearch);
            grpFunction.Controls.Add(btnSearch);
            grpFunction.Controls.Add(btnClearSearch);

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(20, 290);
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1040, 300);
            dgvProducts.CellClick += dgvProducts_CellClick;

            ClientSize = new Size(1080, 620);
            Controls.Add(grpProductInfo);
            Controls.Add(grpFunction);
            Controls.Add(dgvProducts);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.3 - Quản lý danh sách sản phẩm";
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            grpFunction.ResumeLayout(false);
            grpFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }
    }
}
