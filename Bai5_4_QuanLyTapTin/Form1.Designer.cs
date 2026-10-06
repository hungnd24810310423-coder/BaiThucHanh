namespace Bai5_4_QuanLyTapTin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private ComboBox cboView;
        private Label lblView;
        private ImageList imageList1;
        private ColumnHeader colId;
        private ColumnHeader colName;
        private ColumnHeader colPosition;
        private ColumnHeader colJoinDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            lsvEmployees = new ListView();
            cboView = new ComboBox();
            lblView = new Label();
            imageList1 = new ImageList(components);
            colId = new ColumnHeader();
            colName = new ColumnHeader();
            colPosition = new ColumnHeader();
            colJoinDate = new ColumnHeader();

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            // splitContainer1
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;

            // Panel1
            splitContainer1.Panel1.Controls.Add(tvDepartments);

            // Panel2
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Controls.Add(cboView);
            splitContainer1.Panel2.Controls.Add(lblView);

            // tvDepartments
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.Font = new Font("Segoe UI", 10F);
            tvDepartments.HideSelection = false;
            tvDepartments.Name = "tvDepartments";
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;

            // lblView
            lblView.AutoSize = true;
            lblView.Location = new Point(12, 12);
            lblView.Name = "lblView";
            lblView.Size = new Size(83, 19);
            lblView.Text = "Chế độ xem:";

            // cboView
            cboView.DropDownStyle = ComboBoxStyle.DropDownList;
            cboView.FormattingEnabled = true;
            cboView.Items.AddRange(new object[] {
                "Details",
                "SmallIcon",
                "LargeIcon",
                "List",
                "Tile"
            });
            cboView.Location = new Point(101, 9);
            cboView.Name = "cboView";
            cboView.Size = new Size(150, 28);
            cboView.SelectedIndex = 0;
            cboView.SelectedIndexChanged += cboView_SelectedIndexChanged;

            // imageList1
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(32, 32);

            // lsvEmployees
            lsvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.HideSelection = false;
            lsvEmployees.Location = new Point(10, 48);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(710, 460);
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            lsvEmployees.SmallImageList = imageList1;
            lsvEmployees.LargeImageList = imageList1;
            lsvEmployees.Columns.AddRange(new ColumnHeader[] {
                colId, colName, colPosition, colJoinDate
            });

            colId.Text = "Mã NV";
            colId.Width = 90;
            colName.Text = "Họ Tên";
            colName.Width = 210;
            colPosition.Text = "Chức vụ";
            colPosition.Width = 180;
            colJoinDate.Text = "Ngày vào làm";
            colJoinDate.Width = 130;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(750, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Trình quản lý tập tin chuyên nghiệp";
            Load += Form1_Load;

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
