namespace LoginForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailable;
        private Label lblSelected;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private GroupBox grpPayment;
        private Label lblTotalTitle;
        private Label lblTotal;
        private Label lblDiscountTitle;
        private Label lblDiscountPercent;
        private Label lblPaymentTitle;
        private Label lblPayment;
        private Label lblDiscountCode;
        private TextBox txtDiscountCode;
        private Button btnApplyDiscount;
        private Button btnNew;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailable = new Label();
            lblSelected = new Label();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            grpPayment = new GroupBox();
            lblTotalTitle = new Label();
            lblTotal = new Label();
            lblDiscountTitle = new Label();
            lblDiscountPercent = new Label();
            lblPaymentTitle = new Label();
            lblPayment = new Label();
            lblDiscountCode = new Label();
            txtDiscountCode = new TextBox();
            btnApplyDiscount = new Button();
            btnNew = new Button();
            grpPayment.SuspendLayout();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(250, 20);
            lblTitle.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(35, 75);
            lblCategory.Text = "Loại dịch vụ:";

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.Location = new Point(125, 72);
            cboCategory.Size = new Size(240, 28);
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;

            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvailable.Location = new Point(35, 120);
            lblAvailable.Text = "Dịch vụ có sẵn";

            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelected.Location = new Point(465, 120);
            lblSelected.Text = "Dịch vụ đã chọn";

            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 20;
            lstAvailableServices.Location = new Point(35, 150);
            lstAvailableServices.Size = new Size(330, 164);
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;

            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 20;
            lstSelectedServices.Location = new Point(465, 150);
            lstSelectedServices.Size = new Size(330, 164);

            btnSelect.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSelect.Location = new Point(385, 165);
            btnSelect.Size = new Size(55, 42);
            btnSelect.Text = ">";
            btnSelect.Click += btnSelect_Click;

            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.Location = new Point(385, 215);
            btnRemove.Size = new Size(55, 42);
            btnRemove.Text = "<";
            btnRemove.Click += btnRemove_Click;

            btnClearAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClearAll.Location = new Point(385, 265);
            btnClearAll.Size = new Size(55, 42);
            btnClearAll.Text = "<<";
            btnClearAll.Click += btnClearAll_Click;

            grpPayment.Text = "Thông tin thanh toán";
            grpPayment.Location = new Point(35, 340);
            grpPayment.Size = new Size(760, 145);

            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(20, 32);
            lblTotalTitle.Text = "Tổng tiền chưa giảm:";
            lblTotal = new Label();
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(175, 32);
            lblTotal.Text = "0 đ";

            lblDiscountTitle.AutoSize = true;
            lblDiscountTitle.Location = new Point(20, 67);
            lblDiscountTitle.Text = "Tỷ lệ chiết khấu:";
            lblDiscountPercent.AutoSize = true;
            lblDiscountPercent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiscountPercent.Location = new Point(175, 67);
            lblDiscountPercent.Text = "0%";

            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.Location = new Point(20, 102);
            lblPaymentTitle.Text = "Thành tiền thanh toán:";
            lblPayment = new Label();
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPayment.Location = new Point(175, 102);
            lblPayment.Text = "0 đ";

            lblDiscountCode.AutoSize = true;
            lblDiscountCode.Location = new Point(385, 35);
            lblDiscountCode.Text = "Mã giảm giá:";
            txtDiscountCode.Location = new Point(475, 32);
            txtDiscountCode.Size = new Size(120, 27);
            btnApplyDiscount.Location = new Point(605, 30);
            btnApplyDiscount.Size = new Size(125, 32);
            btnApplyDiscount.Text = "Áp dụng";
            btnApplyDiscount.Click += btnApplyDiscount_Click;

            grpPayment.Controls.Add(lblTotalTitle);
            grpPayment.Controls.Add(lblTotal);
            grpPayment.Controls.Add(lblDiscountTitle);
            grpPayment.Controls.Add(lblDiscountPercent);
            grpPayment.Controls.Add(lblPaymentTitle);
            grpPayment.Controls.Add(lblPayment);
            grpPayment.Controls.Add(lblDiscountCode);
            grpPayment.Controls.Add(txtDiscountCode);
            grpPayment.Controls.Add(btnApplyDiscount);

            btnNew.Location = new Point(570, 500);
            btnNew.Size = new Size(105, 35);
            btnNew.Text = "Làm mới";
            btnNew.Click += btnNew_Click;

            ClientSize = new Size(835, 555);
            Controls.Add(lblTitle);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailable);
            Controls.Add(lblSelected);
            Controls.Add(lstAvailableServices);
            Controls.Add(lstSelectedServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(grpPayment);
            Controls.Add(btnNew);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Bảng tính tiền dịch vụ";
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
