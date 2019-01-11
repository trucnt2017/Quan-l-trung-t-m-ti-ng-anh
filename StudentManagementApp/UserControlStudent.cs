using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using DBLayer;
using System.Data;

namespace StudentManagementApp
{
    public partial class UserControlStudent : UserControl
    {
        DBStudent dbStudent;
        DBInputExam dbInputExam;
        BindingSource studentList = new BindingSource();

        public UserControlStudent()
        {
            InitializeComponent();
            dbInputExam = new DBInputExam();
            
        }

        private void btnProcessView_Click(object sender, EventArgs e) // xử lý nút xem quá trình đăng kí à lớp học
        {
            Panel pnlManage = this.Parent as Panel;
            if (pnlManage != null)
            {
                UserControlProcessView processviewControlUser = new UserControlProcessView();
                processviewControlUser.GetInfo(dtgvStudent.CurrentRow.Cells[0].Value.ToString(),dtgvStudent.CurrentRow.Cells[1].Value.ToString());
                // đưa hông tin ở đây là mã học viên qua cho user control processview
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(processviewControlUser);
                processviewControlUser.Dock = DockStyle.Fill;
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e) // xử lý nút thay đổi thông tin
        {
            try
            {
                Panel pnlManage = this.Parent as Panel;
                if (pnlManage != null)
                {
                    UserControlChangeInfo changeinfoControlUser = new UserControlChangeInfo();
                    changeinfoControlUser.GetInfo(dtgvStudent.CurrentRow.Cells["ID_Student"].Value.ToString(),
                        dtgvStudent.CurrentRow.Cells["StudentName"].Value.ToString(),
                        dtgvStudent.CurrentRow.Cells["Gender"].Value.ToString(),
                        dtgvStudent.CurrentRow.Cells["Birthday"].Value.ToString(),
                        dtgvStudent.CurrentRow.Cells["PhoneNumber"].Value.ToString(),
                        dtgvStudent.CurrentRow.Cells["SAddress"].Value.ToString());
                    // lần lượt gửi thông tin cần thiết qua cho user control change Info như mã, tên, sdt, giới tính ,..
                    pnlManage.Controls.Clear();
                    pnlManage.Controls.Add(changeinfoControlUser);
                    changeinfoControlUser.Dock = DockStyle.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertInputPoint_Click(object sender, EventArgs e)// xử lý nút thêm điểm thi đầu vào cho học viên
        {
            try
            {
                Panel pnlManage = this.Parent as Panel;
                int point = dbInputExam.GetPointStudent(dtgvStudent.CurrentRow.Cells["ID_Student"].Value.ToString());
                // hàm lấy điểm thi đầu vào của học viên 
                if (pnlManage != null)
                {
                    UserControlInsertInputPoint insertinputPointControlUser = new UserControlInsertInputPoint();
                    insertinputPointControlUser.GetInfo(dtgvStudent.CurrentRow.Cells["ID_Student"].Value.ToString(),
                    dtgvStudent.CurrentRow.Cells["StudentName"].Value.ToString(), point);
                    // đưa thông tin vào user control là mã, tên, điểm nếu có
                    pnlManage.Controls.Clear();
                    pnlManage.Controls.Add(insertinputPointControlUser);
                    insertinputPointControlUser.Dock = DockStyle.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlStudent_Load(object sender, EventArgs e)
        {
            dbStudent = new DBStudent(); // khởi tạo lớp BAL

            LoadListStudent(); // load danh sách học sinh

            dtgvStudent.DataSource = studentList; // đẩy source vào cho datagridview
        }

        public void LoadListStudent()
        {
            studentList.DataSource = dbStudent.GetListStudent(); // hàm load dữ liệu gán cho source binding qua lớp BAL gọi hàm GetListStudent
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) // khi xảy ra sự kiển thay đổi text
        {
            studentList.DataSource = dbStudent.SearchListStudent(txtSearch.Text.ToString()); // tìm kiểm theo stored procedure
            dtgvStudent.DataSource = studentList; // load lại list và đưa vào datagridview
        }
    }
}
