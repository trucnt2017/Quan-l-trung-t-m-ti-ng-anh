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
    public partial class UserControlClassManage : UserControl
    {
        DBClassType dbClassType;
        DBClassLevel dbClassLevel;
        DBClass dbClass;

        int loai = 0;
        string maloailop = "";
        string tenloailop = "";
        string malop = "";
        string tenlop = "";
        public UserControlClassManage()
        {
            // load các trường combo box , các item vào combo box 
            InitializeComponent();
            dbClassType = new DBClassType();
            dbClassLevel = new DBClassLevel();
            dbClass = new DBClass();
            cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            cbDate1.SelectedItem = cbDate1.Items[0];
            cbDate2.SelectedItem = cbDate2.Items[0];
            cbClassLevel.DataSource = dbClassLevel.GetListClassLevel(); // lấy danh sách cấp lớp
            cbClassLevel.DisplayMember = "ClassLevel_Name"; // hiển thị theo tên cấp độ
            cbClassType.DataSource = dbClassType.GetListClassType(); // lấy danh sách loại lớp
            cbClassType.DisplayMember = "ClassType_Name"; // hiển thị theo tên loại lớp
        }

        public void getLoaiThamSo(int loai, string maloailop, string tenloailop,string malop,string tenlop) // lấy vào xử lý về loại lớp hay lớp
        {
            this.loai = loai;
            this.maloailop = maloailop;
            this.tenloailop = tenloailop;
            this.malop = malop;
            this.tenlop = tenlop;
        }

        public void setControl() // set cái control trên form
        {
            if (loai == 1) // thêm loai lớp
            {
                txtIDClass.Enabled = false;        
                txtOldClass.Enabled = false;
                txtNewClass.Enabled = false;
                cbStudyingTime.Enabled = false;
                cbDate1.Enabled = false;
                cbDate2.Enabled = false;
                cbClassLevel.Enabled = false;
                txtOldClassType.Enabled = false;
                cbClassType.Enabled = false;
                txtNewClassType.Text = "";
                txtIDClassType.Text = "";
            }
            else if(loai == 2) // chỉnh sửa loại lớp
            {
                txtIDClass.Enabled = false;
                txtOldClass.Enabled = false;
                txtNewClass.Enabled = false;
                cbStudyingTime.Enabled = false;
                cbDate1.Enabled = false;
                cbDate2.Enabled = false;
                cbClassLevel.Enabled = false;
                txtIDClassType.Text = maloailop;
                txtOldClassType.Text = tenloailop;
                txtIDClassType.ReadOnly = true;
                txtOldClassType.ReadOnly = true;
                cbClassType.Enabled = false;
                txtNewClassType.Text = "";
            }
            else if(loai == 3) // thêm lớp
            {
                txtIDClassType.Text = maloailop;
                txtOldClassType.Text = tenloailop;
                txtIDClassType.ReadOnly = true;
                txtOldClassType.ReadOnly = true;
                txtNewClassType.Enabled = false;
                txtOldClass.Enabled = false;
                cbClassType.Enabled = false;
                int index = -1, i = 0;
                foreach (ClassType ct in cbClassType.Items) // dùng vòng lặp để tìm 
                {
                    if (ct.ClassType_Name.Equals(tenloailop)) // nếu item trong combobox giống customertypename thì lưu vị trí index đó lại 
                        index = i;
                    i++;
                }
                cbClassType.SelectedIndex = index; // set item là index 

                txtIDClass.Text = "";
                txtNewClass.Text = "";
                cbDate1.SelectedItem = cbDate1.Items[0];
                cbDate2.SelectedItem = cbDate2.Items[0];
                cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            }
            else if (loai == 4) // thêm loại lớp
            {
                txtIDClass.Text = malop;
                txtOldClass.Text = tenlop;
                txtIDClass.ReadOnly = true;
                txtOldClass.ReadOnly = true;
                txtOldClassType.Enabled = false;               
                txtIDClassType.Text = maloailop;
                txtOldClassType.Text = tenloailop;
                txtIDClassType.Enabled = false;
                txtOldClassType.Enabled = false;
                txtNewClassType.Enabled = false;
                int index = -1, i = 0;
                foreach (ClassType ct in cbClassType.Items) // dùng vòng lặp để tìm 
                {
                    if (ct.ClassType_Name.Equals(tenloailop)) // nếu item trong combobox giống customertypename thì lưu vị trí index đó lại 
                        index = i;
                    i++;
                }
                cbClassType.SelectedIndex = index; // set item là index 

                txtNewClass.Text = "";
                cbDate1.SelectedItem = cbDate1.Items[0];
                cbDate2.SelectedItem = cbDate2.Items[0];
                cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            }
        }

        private void UserControlClassManage_Load(object sender, EventArgs e)
        {
            setControl(); // set cái textbox và thuộc tính readonly
        }

        private void btnSave_Click(object sender, EventArgs e) // sự kiện nút lưu
        {
            if (loai == 1) // đối với thêm loại lớp
            {
                if (txtIDClassType.Text != "" && txtNewClassType.Text != "")
                {
                    if (dbClassType.AddClassType(txtIDClassType.Text, txtNewClassType.Text)) // gọi hàm thêm loại lớp ở BAL
                    {
                        MessageBox.Show("Thêm loại lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm loại lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (loai == 2)
            {
                if (txtNewClassType.Text != "")
                {
                    if (dbClassType.EdiClassType(txtIDClassType.Text, txtNewClassType.Text)) // gọi hàm chỉnh sửa loại lớp ở BAL
                    {
                        MessageBox.Show("Chỉnh sửa loại lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Chỉnh sửa loại lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không có chỉnh sửa nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (loai == 3)
            {
                string macaplop = (cbClassLevel.SelectedItem as ClassLevel).ID_ClassLevel; // lấy ra cấp độ ở combo box 
                if ((txtIDClass.Text != "") && (txtNewClass.Text != "") && (cbDate1.Text != cbDate2.Text)) // check điều kiện
                {
                    if (dbClass.AddClass(txtIDClass.Text.ToString(), txtNewClass.Text.ToString(),
                        maloailop, macaplop, cbStudyingTime.Text.ToString(), cbDate1.Text.ToString(), cbDate2.Text.ToString()))
                        // gọi hàm thêm lớp
                    {
                        MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thiếu dữ liệu hoặc 2 buổi học trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (loai == 4) // chỉnh sửa lớp
            {
                string macaplop = (cbClassLevel.SelectedItem as ClassLevel).ID_ClassLevel; // lấy mã cấp độ
                string maloailop = (cbClassType.SelectedItem as ClassType).ID_ClassType; // lấy mã loại lớp
                if (txtNewClass.Text != "" && (cbDate1.Text != cbDate2.Text))
                {
                    if (dbClass.EditClass(txtIDClass.Text.ToString(), txtNewClass.Text.ToString(),
                        maloailop, macaplop, cbStudyingTime.Text.ToString(), cbDate1.Text.ToString(), cbDate2.Text.ToString()))
                        // gọi hàm chỉnh sửa lớp ở lớp DBClass
                    {
                        MessageBox.Show("Chỉnh sửa lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa lớp thất bại khi lớp đã có học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thiếu dữ liệu hoặc 2 buổi học trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setControl();
        }
    }
}
