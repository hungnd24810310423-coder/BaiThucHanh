namespace LoginForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            grpGender = new GroupBox();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(265, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(105, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(250, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(390, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(105, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(250, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(390, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(105, 158);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(110, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(250, 154);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(390, 23);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(105, 196);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(67, 15);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(250, 192);
            dtpBirthDate.MaxDate = DateTime.Today;
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 8;
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(250, 225);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(390, 55);
            grpGender.TabIndex = 9;
            grpGender.TabStop = false;
            grpGender.Text = "Giới tính";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(100, 22);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(41, 19);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(25, 22);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(49, 19);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(250, 295);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(255, 19);
            chkTerms.TabIndex = 10;
            chkTerms.Text = "Tôi đồng ý với Điều khoản dịch vụ";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(250, 335);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 32);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(390, 335);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 32);
            btnReset.TabIndex = 12;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 410);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(chkTerms);
            Controls.Add(grpGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Đăng Ký Tài Khoản";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private GroupBox grpGender;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private CheckBox chkTerms;
        private Button btnRegister;
        private Button btnReset;
        private ErrorProvider epCheck;
    }
}
