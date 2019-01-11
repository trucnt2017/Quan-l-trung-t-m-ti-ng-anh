using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BALayer;

namespace StudentManagementApp
{
    public partial class UserControlChangeInfo : UserControl
    {
        DBStudent dbStudent;
        string id;
        string name;
        string gender;
        string birthday;
        string phone;
        string address;

        public UserControlChangeInfo()
        {
            InitializeComponent();
            dbStudent = new DBStudent();
            dtpBirthday.CustomFormat = "dd-MM-yyyy"; // định dạng ngày tháng
            dtpBirthday.Format = DateTimePickerFormat.Custom;
        }

        public void GetInfo(string id, string name, string gender, string birthday, string phone, string address) // lấy thông tin từ form student
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.phone = phone;
            this.address = address;
        }


        private void UserControlChangeInfo_Load(object sender, EventArgs e) // load dữ liệu ban đầu cho usercontrol
        {
            txtIDstudent.Text = id;
            txtIDstudent.ReadOnly = true;
            txtName.Text = name;
            if (gender.Equals("Nam")) // lấy radio checked
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            string[] tempsplit = birthday.Split('/');
            string newdate = tempsplit[0] + '-' + tempsplit[1] + '-' + tempsplit[2]; // hàm cắt chuỗi ngày tháng để đưa vào database
            dtpBirthday.Text = newdate;
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                rdNu.Checked = false;
            else
                rdNu.Checked = true;
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
                rdNu.Checked = false;
            else
                rdNu.Checked = true;
        }

        public string ConvertDate(DateTime date) // convert ngày đưa về dạng yyy-MM-dd
        {
            string result = date.ToString().Split(' ')[0];
            string[] tempsplit = result.Split('/');
            string newdate = tempsplit[2] + '/' + tempsplit[1] + '/' + tempsplit[0];
            return newdate;
        }

        private void btnSave_Click(object sender, EventArgs e) // lưu dữ liệu đã thay đổi
        {
            string temp = rdNam.Checked ? "Nam" : "Nữ";
            // gọi hàm edit student ở lớp BAL
            if (dbStudent.EditStudent(txtIDstudent.Text, txtName.Text, temp, ConvertDate(dtpBirthday.Value),
                txtPhone.Text, txtAddress.Text))
            {
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e) // reset lại form, load dữ liệu theo các trường khi lần lưu cuối
        {
            txtIDstudent.Text = id;
            txtIDstudent.ReadOnly = true;
            txtName.Text = name;
            if (gender.Equals("Nam"))
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            string[] tempsplit = birthday.Split('/');
            string newdate = tempsplit[0] + '-' + tempsplit[1] + '-' + tempsplit[2];
            dtpBirthday.Text = newdate;
        }
    }
}
