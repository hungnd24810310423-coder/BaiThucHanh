using System.ComponentModel;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private readonly BindingSource bindingSource = new();
        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();
            cboCategory.SelectedIndex = 0;
            bindingSource.DataSource = new BindingList<Product>(products);
            dgvProducts.DataSource = bindingSource;
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            products.Add(new Product("SP01", "Laptop Dell", 15000000, 5, "Laptop"));
            products.Add(new Product("SP02", "iPhone 15", 20000000, 3, "Điện thoại"));
            products.Add(new Product("SP03", "Chuột Logitech", 500000, 10, "Phụ kiện"));
            bindingSource.ResetBindings(false);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SP!");
                txtProductId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên SP!");
                txtProductName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!");
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên hợp lệ!");
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private Product GetProductFromInput()
        {
            decimal.TryParse(txtUnitPrice.Text, out decimal price);
            int.TryParse(txtQuantity.Text, out int quantity);

            return new Product(
                txtProductId.Text.Trim(),
                txtProductName.Text.Trim(),
                price,
                quantity,
                cboCategory.Text
            );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (products.Any(p => p.ProductId.Equals(txtProductId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                txtProductId.Focus();
                return;
            }

            products.Add(GetProductFromInput());
            bindingSource.ResetBindings(false);
            ClearInput();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            if (!ValidateInput()) return;

            Product newProduct = GetProductFromInput();
            int index = products.IndexOf(selectedProduct);
            products[index] = newProduct;
            selectedProduct = newProduct;
            bindingSource.ResetBindings(false);
            MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                bindingSource.ResetBindings(false);
                ClearInput();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                bindingSource.DataSource = new BindingList<Product>(products);
                return;
            }

            List<Product> result = products
                .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            bindingSource.DataSource = new BindingList<Product>(result);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvProducts.Rows.Count) return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product product)
            {
                selectedProduct = product;
                txtProductId.Text = product.ProductId;
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString("0");
                txtQuantity.Text = product.Quantity.ToString();
                cboCategory.Text = product.Category;
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            bindingSource.DataSource = new BindingList<Product>(products);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            selectedProduct = null;
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            cboCategory.SelectedIndex = 0;
            dgvProducts.ClearSelection();
        }
    }
}
