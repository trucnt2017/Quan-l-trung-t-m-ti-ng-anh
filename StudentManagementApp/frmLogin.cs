using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using DBLayer;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StudentManagementApp
{
    public partial class frmLogin : Form  // giao diên làm việc với việc đăng nhập
    {
        public DBAccount db;
        public frmLogin()
        {
            InitializeComponent();
            db = new DBAccount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.CheckLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString()) == 1) 
                // gọi hàm checklogin trong db truyền user, pass, type
                // ở đây chỉ làm việc với học viên nên chưa phân thành nhiều loại
                // phát triển có thể thêm giảng viên, nhân viên ghi danh
            {
                frmMain fmain = new frmMain(); // nếu đúng truy cập form Main
                this.Hide(); // đóng form này
                fmain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e) // nút reset mật khẩu mặc định là 123
        {
            if(MessageBox.Show("Bạn chắc chắn muốn khôi phục mật khẩu mặc định cho tài khoản",
                "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(db.ResetPassword(txtUsername.Text.ToString())) // nếu thực hiện được
                {
                    MessageBox.Show("Bạn đã khổi phục mật khẩu thành công. Mật khẩu là 123", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn đã khôi phục mật khẩu không thành công. Yêu cầu kiểm tra lại tên đăng nhập", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e) // xử lý nút thông tin
        {
            MessageBox.Show("Tên đề tài: Quản lý học viên trung tâm Tiếng Anh\nNhóm : 14\nThông tin nhóm:\n  1. Bùi Phan Viết Cường - MSSV : 15110173\n  2. Nguyễn Thị Trúc - MSSV : 15110349\n\n\nTài khoản đăng nhập : admin - Mật khẩu : admin",
                "Đồ án môn Hệ quản trị Cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
