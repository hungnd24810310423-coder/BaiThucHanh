using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_4_QuanLyTapTin
{
    public partial class Form1 : Form
    {
        private readonly List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateImageList();
            CreateEmployees();
            CreateTree();
            cboView.SelectedIndex = 0;
            tvDepartments.SelectedNode = tvDepartments.Nodes[0];
        }

        private void CreateImageList()
        {
            imageList1.Images.Clear();

            Bitmap company = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(company))
            {
                g.Clear(Color.LightSteelBlue);
                g.DrawRectangle(Pens.Navy, 4, 5, 24, 22);
                g.FillRectangle(Brushes.White, 8, 10, 5, 5);
                g.FillRectangle(Brushes.White, 19, 10, 5, 5);
                g.FillRectangle(Brushes.White, 8, 19, 5, 5);
                g.FillRectangle(Brushes.White, 19, 19, 5, 5);
            }

            Bitmap folder = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(folder))
            {
                g.Clear(Color.LightYellow);
                g.FillRectangle(Brushes.Goldenrod, 3, 8, 26, 18);
                g.FillRectangle(Brushes.Khaki, 5, 5, 12, 6);
            }

            Bitmap person = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(person))
            {
                g.Clear(Color.LightGreen);
                g.FillEllipse(Brushes.SteelBlue, 10, 4, 12, 12);
                g.FillEllipse(Brushes.SteelBlue, 6, 16, 20, 12);
            }

            imageList1.Images.Add(company);
            imageList1.Images.Add(folder);
            imageList1.Images.Add(person);

            tvDepartments.ImageList = imageList1;
            tvDepartments.SelectedImageIndex = 0;
        }

        private void CreateEmployees()
        {
            employees.Add(new Employee("NV001", "Nguyễn Văn An", "Trưởng phòng", "10/01/2020", "Phòng Kinh doanh", "Nhóm Kinh doanh 1"));
            employees.Add(new Employee("NV002", "Trần Thị Bình", "Nhân viên", "15/03/2022", "Phòng Kinh doanh", "Nhóm Kinh doanh 1"));
            employees.Add(new Employee("NV003", "Lê Minh Cường", "Nhân viên", "20/06/2023", "Phòng Kinh doanh", "Nhóm Kinh doanh 2"));
            employees.Add(new Employee("NV004", "Phạm Thị Dung", "Trưởng nhóm", "08/08/2021", "Phòng Kinh doanh", "Nhóm Kinh doanh 2"));

            employees.Add(new Employee("NV005", "Hoàng Văn Em", "Trưởng phòng", "12/02/2019", "Phòng Kỹ thuật", "Nhóm Phát triển"));
            employees.Add(new Employee("NV006", "Vũ Thị Hoa", "Lập trình viên", "01/04/2022", "Phòng Kỹ thuật", "Nhóm Phát triển"));
            employees.Add(new Employee("NV007", "Đặng Minh Khoa", "Lập trình viên", "18/09/2023", "Phòng Kỹ thuật", "Nhóm Phát triển"));
            employees.Add(new Employee("NV008", "Nguyễn Quốc Long", "Trưởng nhóm", "25/05/2020", "Phòng Kỹ thuật", "Nhóm Hỗ trợ"));

            employees.Add(new Employee("NV009", "Phan Thị Mai", "Trưởng phòng", "05/01/2018", "Phòng Nhân sự", "Nhóm Tuyển dụng"));
            employees.Add(new Employee("NV010", "Đỗ Văn Nam", "Chuyên viên", "14/07/2021", "Phòng Nhân sự", "Nhóm Tuyển dụng"));
            employees.Add(new Employee("NV011", "Bùi Thị Oanh", "Chuyên viên", "22/11/2022", "Phòng Nhân sự", "Nhóm C&B"));
        }

        private void CreateTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode company = new TreeNode("Công ty ABC");
            company.ImageIndex = 0;
            company.SelectedImageIndex = 0;

            AddDepartment(company, "Phòng Kinh doanh",
                new[] { "Nhóm Kinh doanh 1", "Nhóm Kinh doanh 2" });

            AddDepartment(company, "Phòng Kỹ thuật",
                new[] { "Nhóm Phát triển", "Nhóm Hỗ trợ" });

            AddDepartment(company, "Phòng Nhân sự",
                new[] { "Nhóm Tuyển dụng", "Nhóm C&B" });

            tvDepartments.Nodes.Add(company);
            company.Expand();
        }

        private void AddDepartment(TreeNode company, string department, string[] groups)
        {
            TreeNode departmentNode = new TreeNode(department);
            departmentNode.ImageIndex = 1;
            departmentNode.SelectedImageIndex = 1;

            foreach (string group in groups)
            {
                TreeNode groupNode = new TreeNode(group);
                groupNode.ImageIndex = 2;
                groupNode.SelectedImageIndex = 2;
                departmentNode.Nodes.Add(groupNode);
            }

            company.Nodes.Add(departmentNode);
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadEmployees(e.Node);
        }

        private void LoadEmployees(TreeNode node)
        {
            lsvEmployees.Items.Clear();

            string selected = node.Text;
            IEnumerable<Employee> result;

            if (selected == "Công ty ABC")
            {
                result = employees;
            }
            else if (selected.StartsWith("Phòng "))
            {
                result = employees.Where(x => x.Department == selected);
            }
            else
            {
                result = employees.Where(x => x.Group == selected);
            }

            foreach (Employee employee in result)
            {
                ListViewItem item = new ListViewItem(employee.Id, 2);
                item.SubItems.Add(employee.FullName);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.JoinDate);
                lsvEmployees.Items.Add(item);
            }
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.SelectedItem?.ToString())
            {
                case "Details":
                    lsvEmployees.View = View.Details;
                    break;
                case "SmallIcon":
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case "LargeIcon":
                    lsvEmployees.View = View.LargeIcon;
                    break;
                case "List":
                    lsvEmployees.View = View.List;
                    break;
                case "Tile":
                    lsvEmployees.View = View.Tile;
                    break;
            }
        }
    }
}
