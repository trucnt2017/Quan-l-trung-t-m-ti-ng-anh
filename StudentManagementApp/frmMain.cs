using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentManagementApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e) // khi load form lần đầu tiên
        {
            btnRegister.BackColor = SystemColors.ControlLight;
            UserControlRegister user = new UserControlRegister(); // tạo usercontrol mặc định là usercontrol Register
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(user);
            user.Dock = DockStyle.Fill; // lấp đầy form vào panel đã định sẵn ở form chính
        }

        private void btnRegister_Click(object sender, EventArgs e) // khi nhấn nút đăng ký load usercontrol Register ra
        {
            btnRegister.BackColor = SystemColors.ControlLight;
            btnStudent.BackColor = SystemColors.ControlLightLight;
            btnClass.BackColor = SystemColors.ControlLightLight;
            btnProcess.BackColor = SystemColors.ControlLightLight;
            btnExam.BackColor = SystemColors.ControlLightLight;
            btnSettings.BackColor = SystemColors.ControlLightLight;
            UserControlRegister userControlUser = new UserControlRegister(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(userControlUser);
            userControlUser.Dock = DockStyle.Fill;
        }

        private void btnStudent_Click(object sender, EventArgs e) // khi nhấn nút học viên load usercontrol Student ra quản lý
        {
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnStudent.BackColor = SystemColors.ControlLight;
            btnClass.BackColor = SystemColors.ControlLightLight;
            btnProcess.BackColor = SystemColors.ControlLightLight;
            btnExam.BackColor = SystemColors.ControlLightLight;
            btnSettings.BackColor = SystemColors.ControlLightLight;
            UserControlStudent studentControl = new UserControlStudent(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(studentControl);
            studentControl.Dock = DockStyle.Fill;
        }

        private void btnClass_Click(object sender, EventArgs e) // khi nhấn nút lớp học load usercontrol Class ra quản lý
        {
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnStudent.BackColor = SystemColors.ControlLightLight;
            btnClass.BackColor = SystemColors.ControlLight;
            btnProcess.BackColor = SystemColors.ControlLightLight;
            btnExam.BackColor = SystemColors.ControlLightLight;
            btnSettings.BackColor = SystemColors.ControlLightLight;
            UserControlClass classControl = new UserControlClass(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(classControl);
            classControl.Dock = DockStyle.Fill;
        }

        private void btnProcess_Click(object sender, EventArgs e) // khi nhấn nút quá trình load usercontrol StudyingProcess ra quản lý
        {
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnStudent.BackColor = SystemColors.ControlLightLight;
            btnClass.BackColor = SystemColors.ControlLightLight;
            btnProcess.BackColor = SystemColors.ControlLight;
            btnExam.BackColor = SystemColors.ControlLightLight;
            btnSettings.BackColor = SystemColors.ControlLightLight;
            UserControlProcess processControl = new UserControlProcess(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(processControl);
            processControl.Dock = DockStyle.Fill;
        }

        private void btnExam_Click(object sender, EventArgs e) // khi nhấn nút kì thi đầu ra load usercontrol Output Exam ra quản lý
        {
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnStudent.BackColor = SystemColors.ControlLightLight;
            btnClass.BackColor = SystemColors.ControlLightLight;
            btnProcess.BackColor = SystemColors.ControlLightLight;
            btnExam.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLightLight;
            UserControlExam examControl = new UserControlExam(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(examControl);
            examControl.Dock = DockStyle.Fill;
        }

        private void btnSettings_Click(object sender, EventArgs e) // khi nhấn nút cài đặt load usercontrol Settings ra quản lý
        {
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnStudent.BackColor = SystemColors.ControlLightLight;
            btnClass.BackColor = SystemColors.ControlLightLight;
            btnProcess.BackColor = SystemColors.ControlLightLight;
            btnExam.BackColor = SystemColors.ControlLightLight;
            btnSettings.BackColor = SystemColors.ControlLight;
            UserControlSetting settingControl = new UserControlSetting(); // tạo usercontrol
            pnlManage.Controls.Clear();
            pnlManage.Controls.Add(settingControl);
            settingControl.Dock = DockStyle.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e) // xử lý nút thoát
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng này?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e) // xứ lý nút info
        {
            MessageBox.Show("Tên đề tài: Quản lý học viên trung tâm Tiếng Anh\nNhóm : 14\nThông tin nhóm:\n  1. Bùi Phan Viết Cường - MSSV : 15110173\n  2. Nguyễn Thị Trúc - MSSV : 15110349",
                "Đồ án môn Hệ quản trị Cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMin_Click(object sender, EventArgs e) // xử lý nút thu nhỏ cửa sổ
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        #region MoveForm  //hàm kéo thả form bằng panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
