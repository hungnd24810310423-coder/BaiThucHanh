namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            epCheck.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống.");
                isValid = false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu nhập lại không khớp.");
                isValid = false;
            }

            int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate, "Người đăng ký phải đủ 18 tuổi.");
                isValid = false;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                epCheck.SetError(grpGender, "Vui lòng chọn giới tính.");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với điều khoản dịch vụ.");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            string gender = rdoMale.Checked ? "Nam" : "Nữ";

            MessageBox.Show(
                "Đăng ký tài khoản thành công!\n\n" +
                "Tên đăng nhập: " + txtUsername.Text +
                "\nNgày sinh: " + dtpBirthDate.Value.ToString("dd/MM/yyyy") +
                "\nGiới tính: " + gender,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkTerms.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}
