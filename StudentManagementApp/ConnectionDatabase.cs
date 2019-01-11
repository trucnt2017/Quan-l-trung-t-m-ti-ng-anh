using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace StudentManagementApp
{
    public partial class ConnectionDatabase : Form  // giao diện kết nối tới server
    {
        DAL db;
        public ConnectionDatabase() 
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e) // sự kiện click nút kết nối
        {
            if (txtIP.Text != "" && txtUser.Text != "" && txtPass.Text != "")
            {
                db = new DAL(txtIP.Text.ToString(), txtUser.Text.ToString(), txtPass.Text.ToString());
                if (db.checkConnect()) // hàm kiểm tra kết nối nếu có kết nối thì truy cập form login
                {
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("IP, user, pass không đúng. Vui lòng nhập lại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) // xử lý nút thoát
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e) // xử lý nút thông tin
        {
            MessageBox.Show("Tên đề tài: Quản lý học viên trung tâm Tiếng Anh\nNhóm : 14\nThông tin nhóm:\n  1. Bùi Phan Viết Cường - MSSV : 15110173\n  2. Nguyễn Thị Trúc - MSSV : 15110349\n\n\nTài khoản đăng nhập : LoginNhom14 - Mật khẩu : 1234",
                "Đồ án môn Hệ quản trị Cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
