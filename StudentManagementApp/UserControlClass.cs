using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using BALayer;

namespace StudentManagementApp
{
    public partial class  UserControlClass : UserControl
    {
        // khởi tạo các lớp BAL cần thiết
        int loai = 0;
        public DBClassType dbClassType;
        public DBClass dbClass;
        // khởi tạo source data binding
        BindingSource classTypeList = new BindingSource();
        BindingSource classList = new BindingSource();

        public UserControlClass()
        {
            InitializeComponent();
        }

        private void UserControlClass_Load(object sender, EventArgs e)
        {
            dbClassType = new DBClassType();
            dbClass = new DBClass();

            loadClassTypeList(); // load danh sách loại lớp

            dtgClassType.DataSource = classTypeList; // gán source cho datagridview ClassType
            dtgvClass.DataSource = classList; // gán source cho datagridview Class
        }

        public void loadClassTypeList() // load danh sách loại lớp
        {
            classTypeList.DataSource = dbClassType.GetListClassType(); // lấy hàm getlistclasstype của lớp BAL DBClassType
        }

        public void LoadClass() // tải danh sách lớp 
        {
            string id = dtgClassType.CurrentRow.Cells[0].Value.ToString();
            try
            {
                classList.DataSource = dbClass.GetListClass(id); // tải danh sách lớp theo mã loại lớp
            }
            catch
            {
                MessageBox.Show("Lỗi Tải Danh sách lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnEditClass_Click(object sender, EventArgs e) // xử lý sự kiện nút chỉnh sửa
        {
            loai = 4; // loai 4 la chinh sua lop
            Panel pnlManage = this.Parent as Panel;
            string maloailop = dtgClassType.CurrentRow.Cells["ID_ClassType"].Value.ToString();
            string tenloailop = dtgClassType.CurrentRow.Cells["ClassType_Name"].Value.ToString();
            string malop = dtgvClass.CurrentRow.Cells["ID_Class"].Value.ToString();
            string tenlop = dtgvClass.CurrentRow.Cells["Class_Name"].Value.ToString();
            if (pnlManage != null)
            {
                UserControlClassManage classmanageControlUser = new UserControlClassManage();
                classmanageControlUser.getLoaiThamSo(loai,maloailop,tenloailop,malop,tenlop);
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(classmanageControlUser);
                classmanageControlUser.Dock = DockStyle.Fill;
            }
        }

        private void btnEditClassType_Click(object sender, EventArgs e)
        {
            loai = 2; // loai 2 la chinh sua loai lop
            string maloailop = dtgClassType.CurrentRow.Cells["ID_ClassType"].Value.ToString();
            string tenloailop = dtgClassType.CurrentRow.Cells["ClassType_Name"].Value.ToString();
            Panel pnlManage = this.Parent as Panel;
            if (pnlManage != null)
            {
                UserControlClassManage classmanageControlUser = new UserControlClassManage();
                classmanageControlUser.getLoaiThamSo(loai,maloailop,tenloailop,"","");
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(classmanageControlUser);
                classmanageControlUser.Dock = DockStyle.Fill;
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            loai = 3; // them lớp
            Panel pnlManage = this.Parent as Panel;
            string maloailop = dtgClassType.CurrentRow.Cells["ID_ClassType"].Value.ToString();
            string tenloailop = dtgClassType.CurrentRow.Cells["ClassType_Name"].Value.ToString();
            if (pnlManage != null)
            {
                UserControlClassManage classmanageControlUser = new UserControlClassManage();
                classmanageControlUser.getLoaiThamSo(loai,maloailop,tenloailop,"","");
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(classmanageControlUser);
                classmanageControlUser.Dock = DockStyle.Fill;
            }
        }

        private void btnAddClassType_Click(object sender, EventArgs e)
        {
            loai = 1; // them loai lớp
            Panel pnlManage = this.Parent as Panel;
            if (pnlManage != null)
            {
                UserControlClassManage classmanageControlUser = new UserControlClassManage();
                classmanageControlUser.getLoaiThamSo(loai,"","","","");
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(classmanageControlUser);
                classmanageControlUser.Dock = DockStyle.Fill;
            }
        }

        private void dtgClassType_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadClass(); // load danh sách lớp học vào datagridview
            dtgvClass.Columns["IDClassType_Class"].Visible = false; // ẩn đi id loại lớp và id cấp lớp
            dtgvClass.Columns["IDClassLevel"].Visible = false;
        }

        private void btnDeleteClassType_Click(object sender, EventArgs e) // xử lý nút xóa loại lớp
        {
            string maloailop = dtgClassType.CurrentRow.Cells["ID_ClassType"].Value.ToString();
            if (dbClassType.DeleteClassType(maloailop))
            {
                MessageBox.Show("Xóa loại lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadClassTypeList(); // load lại danh sách loại lớp
            }
            else
            {
                MessageBox.Show("Không thể xóa loại lớp đang có lớp giảng dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadClassTypeList(); // load lại danh sách lớp
            }
        }

        private void btnCancelClass_Click(object sender, EventArgs e) // xử lý hủy lớp
        {
            string malop = dtgvClass.CurrentRow.Cells["ID_Class"].Value.ToString();// lấy mã lớp
            if(dbClass.DeleteClass(malop)) // gọi hàm xóa lớp
            {
                MessageBox.Show("Xóa lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClass(); // load lại danh sách lớp
            }
            else
            {
                MessageBox.Show("Không thể huỷ lớp đang đã có sinh viên đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadClass();
            }
        }
    }
}
