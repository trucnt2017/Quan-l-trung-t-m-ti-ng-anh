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

namespace StudentManagementApp
{
    public partial class UserControlProcessView : UserControl
    {
        string studentID = "";
        string studentName = "";

        DBStudent dbStudent;

        BindingSource registerList = new BindingSource();
        BindingSource classList = new BindingSource();

        public UserControlProcessView()
        {
            InitializeComponent();
            dbStudent = new DBStudent();
        }

        public void GetInfo(string studentID, string studentName) // lấy thông tin là mã học viên và tên
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }

        private void UserControlProcessView_Load(object sender, EventArgs e)
        {
            try
            {
                // set các control trên user control
                txtStudentID.Text = studentID;
                txtStudentName.Text = studentName;
                txtStudentID.ReadOnly = true;
                txtStudentName.ReadOnly = true;

                registerList.DataSource = dbStudent.GetListHistoryRegister(txtStudentID.Text); // lấy lịch sử đăng kí qua lớp BAL
                dtgvRegisterList.DataSource = registerList;

                classList.DataSource = dbStudent.GetListHistoryClass(txtStudentID.Text); // lấy lịch sử các lớp học qua lớp BAL Student
                dtgvClassList.DataSource = classList;
                
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertInputPoint_Click(object sender, EventArgs e) // quay trở lại user control insert point
        {           
            Panel pnlManage = this.Parent as Panel;
            if (pnlManage != null)
            {
                UserControlStudent studentControl = new UserControlStudent(); // tạo usercontrol
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(studentControl);
                studentControl.Dock = DockStyle.Fill;
            }
        }
    }
}
