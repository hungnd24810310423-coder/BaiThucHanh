using System.Globalization;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private class Service
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }

            public Service(string name, string category, decimal price)
            {
                Name = name;
                Category = category;
                Price = price;
            }

            public override string ToString()
            {
                return Name + " - " + Price.ToString("N0") + " đ";
            }
        }

        private readonly List<Service> services = new()
        {
            new Service("Khám tổng quát", "Khám bệnh", 200000),
            new Service("Khám chuyên khoa", "Khám bệnh", 300000),
            new Service("Khám sức khỏe định kỳ", "Khám bệnh", 250000),
            new Service("Xét nghiệm máu", "Xét nghiệm", 150000),
            new Service("Xét nghiệm nước tiểu", "Xét nghiệm", 100000),
            new Service("Xét nghiệm đường huyết", "Xét nghiệm", 120000),
            new Service("Chụp X-Quang ngực", "Chụp X-Quang", 180000),
            new Service("Chụp X-Quang xương", "Chụp X-Quang", 220000),
            new Service("Chụp X-Quang răng", "Chụp X-Quang", 150000),
            new Service("Vắc-xin cúm", "Vắc-xin", 250000),
            new Service("Vắc-xin viêm gan B", "Vắc-xin", 300000),
            new Service("Vắc-xin HPV", "Vắc-xin", 1500000)
        };

        private decimal discountPercent = 0;

        public Form1()
        {
            InitializeComponent();
            cboCategory.SelectedIndex = 0;
            LoadAvailableServices();
            UpdateTotal();
        }

        private void LoadAvailableServices()
        {
            lstAvailableServices.Items.Clear();
            string category = cboCategory.Text;

            foreach (Service service in services)
            {
                if (service.Category == category)
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableServices();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectService();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            SelectService();
        }

        private void SelectService()
        {
            if (lstAvailableServices.SelectedItem is Service service)
            {
                bool exists = lstSelectedServices.Items.Cast<Service>()
                    .Any(x => x.Name == service.Name);

                if (!exists)
                {
                    lstSelectedServices.Items.Add(service);
                    UpdateTotal();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedIndex >= 0)
            {
                lstSelectedServices.Items.RemoveAt(lstSelectedServices.SelectedIndex);
                UpdateTotal();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            discountPercent = 0;
            txtDiscountCode.Clear();
            lblDiscountPercent.Text = "0%";
            UpdateTotal();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            string code = txtDiscountCode.Text.Trim().ToUpper();

            switch (code)
            {
                case "SALE10":
                    discountPercent = 10;
                    break;
                case "SALE15":
                    discountPercent = 15;
                    break;
                case "SALE20":
                    discountPercent = 20;
                    break;
                default:
                    discountPercent = 0;
                    MessageBox.Show("Mã giảm giá không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            lblDiscountPercent.Text = discountPercent + "%";
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (Service service in lstSelectedServices.Items)
            {
                total += service.Price;
            }

            decimal payment = total - total * discountPercent / 100;

            lblTotal.Text = total.ToString("N0") + " đ";
            lblPayment.Text = payment.ToString("N0") + " đ";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            txtDiscountCode.Clear();
            discountPercent = 0;
            lblDiscountPercent.Text = "0%";
            UpdateTotal();
        }
    }
}
