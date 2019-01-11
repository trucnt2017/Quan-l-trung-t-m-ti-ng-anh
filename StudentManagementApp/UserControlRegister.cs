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
using System.Globalization;

namespace StudentManagementApp
{
    public partial class UserControlRegister : UserControl
    {
        DBClassType dbClassType;
        DBStudent db;
        Bitmap bmp;
        public UserControlRegister()
        {
            InitializeComponent();
            // khởi tạo ban đầu cho quá trình đăng ký
            db = new DBStudent();
            dbClassType = new DBClassType();
            dtpBirthday.CustomFormat = "dd-MM-yyyy"; // custom kiểu hiện thị của DateTime
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpInputExamDate.CustomFormat = "dd-MM-yyyy";
            dtpInputExamDate.Format = DateTimePickerFormat.Custom;
            rdNam.Checked = true;
            rdNu.Checked = false;
            cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            cbDateFirst.SelectedItem = cbDateFirst.Items[0];
            cbDateSecond.SelectedItem = cbDateSecond.Items[0];
            cbClassType.DataSource = dbClassType.GetListClassType(); // load danh sách loại lớp vào combo box
            cbClassType.DisplayMember = "ClassType_Name"; // lấy tên hiển thị
            //btnPrint.Enabled = false;
        }

        public string ConvertDate(DateTime date) // chuyển đổi ngày qua dạng yyy-MM-dd để thêm vào database
        {
            string result = date.ToString().Split(' ')[0];
            string[] tempsplit = result.Split('/');
            string newdate = tempsplit[2] + '/' + tempsplit[1] + '/' + tempsplit[0];
            return newdate;
        }

        public bool CheckPhoneNumber(string phone)
        {
            char[] temp = phone.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 48 || temp[i] > 57)
                    return false;
            }
            return true;
        }

        public bool checkBirthday(DateTime date) // kiểm tra ngày sinh
        {
            if (date < DateTime.Now) 
                return true;
            else                   
                return false;
        }

        public bool checkInputExam(DateTime date) // kiểm tra ngày thi đầu vào
        {
            if (date > DateTime.Now) 
                return true;
            else                    
                return false;
        }

        private void btnAdd_Click(object sender, EventArgs e) // khi nhấn nút thêm đăng ký
        {
            string s = dtpBirthday.Value.ToString(); // lấy ngày sinh
            string gender = rdNam.Checked == true ? "Nam" : "Nữ"; // lấy giới tính
            string idClassType = ""; 
            foreach (ClassType ct in cbClassType.Items)
            {
                if (ct.ClassType_Name.Equals(cbClassType.Text.ToString()))
                    idClassType = ct.ID_ClassType; // lấy mã loại từ combo box
            }
            if (txtIDStudent.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" ||
                numFee.Value == 0 || cbDateFirst.Text == cbDateSecond.Text) // hàm check trường trống
            {
                MessageBox.Show("Không được để trống các trường! 2 buổi học phải khác thứ học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckPhoneNumber(txtPhoneNumber.Text))
                { // check số điện thoại
                    if (!checkBirthday(dtpBirthday.Value)) // check ngày sinh
                    {
                        MessageBox.Show("Ngày sinh không thể lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!checkInputExam(dtpInputExamDate.Value)) // check ngày thi đầu vào
                        {
                            MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                if (db.AddRegisterForNewStudent(txtIDStudent.Text, txtName.Text.ToString(), gender,
                                    ConvertDate(dtpBirthday.Value), txtPhoneNumber.Text.ToString(),
                                    txtAddress.Text.ToString(), cbStudyingTime.Text.ToString(), cbDateFirst.Text.ToString(),
                                    cbDateSecond.Text.ToString(), ConvertDate(dtpInputExamDate.Value), idClassType,
                                    long.Parse(numFee.Value.ToString()))) // hàm thêm đăng kí + học viên (đăng kí lần đầu)
                                {
                                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Kiểm tra trùng số điện thoại hoặc trùng mã học viên!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch
                            {
                                MessageBox.Show("Học phí nhập là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại nhập là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) // tạo tài liệu in
        //{
        //    e.Graphics.DrawImage(bmp,45,45);
        //}

        //private void btnPrint_Click(object sender, EventArgs e) // xử lý nút in
        //{
        //    printPreview.Document = printDoc;
        //    Graphics g = this.CreateGraphics();
        //    bmp = new Bitmap(708, 388, g);
        //    Graphics gh = Graphics.FromImage(bmp);
        //    gh.CopyFromScreen(405,140, 0,0, this.Size);
        //    printPreview.ShowDialog();
        //}

        private void btnCancel_Click(object sender, EventArgs e) // nút hủy reset lại các giá trị của control trên user control
        {
            txtIDStudent.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            numFee.Value = 0;
            rdNam.Checked = true;
            rdNu.Checked = false;
            cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            cbDateFirst.SelectedItem = cbDateFirst.Items[0];
            cbDateSecond.SelectedItem = cbDateSecond.Items[0];
            dtpBirthday.Value = DateTime.Now;
            dtpInputExamDate.Value = DateTime.Now;
            cbClassType.SelectedItem = cbClassType.Items[0];
        }
    }
}
