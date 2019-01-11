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
    public partial class UserControlArrange : UserControl
    {
        // khởi tạo các lớp BAL cần thiết
        DBRegister dbRegister;
        DBClass dbClass;
        DBClassType dbClassType;
        DBClassLevel dbClassLevel;
        DBInputExam dbInputExam;

        // khởi tạo đối tượng học viên cũ đã đăng ký ở trung tâm
        OldStudent oldStudent;

        // tạo các data binding source
        BindingSource classTypeList = new BindingSource();
        BindingSource classLevelList = new BindingSource();
        BindingSource classList = new BindingSource();

        string studentID;
        string classID;

        public UserControlArrange()
        {
            InitializeComponent();

            dbRegister = new DBRegister();
            dbClassType = new DBClassType();
            dbClassLevel = new DBClassLevel();
            dbClass = new DBClass();
            dbInputExam = new DBInputExam();
        }

        public void GetInfo(string studentID, string classID) // lấy thông tin từ form insert input point mã lớp, mã học viên
        {
            this.studentID = studentID;
            this.classID = classID;
        }
        
        public void LoadListClass() // load các dữ liệu cần thiết
        {
            string classtypeid = "";
            string classlevelid = "";

            foreach (ClassType ct in cbClassType.Items) // load loại lớp 
            {
                if (ct.ClassType_Name.Equals(cbClassType.Text.ToString()))
                    classtypeid = ct.ID_ClassType; // lưu lại thông tin loai lớp
            }

            foreach (ClassLevel cl in cbClassLevel.Items) // load cấp độ lớp
            {
                if (cl.ClassLevel_Name.Equals(cbClassLevel.Text.ToString()))
                    classlevelid = cl.ID_ClassLevel; // lưu lại thông tin cấp độ lớp
            }
            try
            {
                classList.DataSource = dbClass.GetListClassForReRegister(txtIDStudent.Text, classtypeid, classlevelid, cbStudyingTime.Text.ToString(),
                    cbDate1.Text.ToString(), cbDate2.Text.ToString()); // load lớp phù hợp thoe lựa chọn ở combox box 
                cbClass.DataSource = classList;
                cbClass.DisplayMember = "ClassName"; // hiển thị cột CLassName ra combox box
                if (classList.Count == 0)
                    cbClass.Text = "Không có lớp phù hợp"; // nếu không tìm thấy
            }
            catch
            {
                cbClass.Text = "Không load được dữ liệu"; // nếu có lỗi
            }

        }

        public void LoadInfoForRegister() // hàm load thông tin vào các combo box
        {
            // load vào binding source
            classTypeList.DataSource = dbClassType.GetListClassType(); // load vào combo box loại lớp
            cbClassType.DataSource = classTypeList;
            cbClassType.DisplayMember = "ClassType_Name";

            classLevelList.DataSource = dbClassLevel.GetListClassLevel(); // load vào combox box cấp lớp
            cbClassLevel.DataSource = classLevelList;
            cbClassLevel.DisplayMember = "ClassLevel_Name";

        }

        public void FillComboBox() // load item mặc định cho combo box
        {
            cbStudyingTime.SelectedItem = cbStudyingTime.Items[0];
            cbDate1.SelectedItem = cbDate1.Items[0];
            cbDate2.SelectedItem = cbDate2.Items[0];
        }
        private void UserControlArrange_Load(object sender, EventArgs e) // sự kiện usercontrol load
        {
            try
            {
                oldStudent = dbRegister.GetInfoStudent(studentID, classID); // load thông tin học viên lên
                txtIDStudent.Text = oldStudent.StudentID;
                txtIDStudent.ReadOnly = true;
                txtStudentName.Text = oldStudent.StudentName;
                txtStudentName.ReadOnly = true;
                txtClassType.Text = oldStudent.ClassTypeName;
                txtClassType.ReadOnly = true;
                txtClassLevel.Text = oldStudent.ClassLevelName;
                txtClassLevel.ReadOnly = true;
                txtClass.Text = oldStudent.ClassName;
                txtClass.ReadOnly = true;
                txtCountStudied.Text = oldStudent.CountStudied.ToString();
                txtCountStudied.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Không thể tải thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                FillComboBox(); // load combobox
                LoadInfoForRegister(); // load thông tin học sinh
                LoadListClass(); // load danh sách lớp theo combo box
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStudyingTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass(); // mỗi lần thay đổi combo box load lại classList
        }

        private void cbClassLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass();// mỗi lần thay đổi combo box load lại classList
        }

        private void cbClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass();// mỗi lần thay đổi combo box load lại classList
        }

        private void cbDate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass();// mỗi lần thay đổi combo box load lại classList
        }

        private void cbDate2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass();// mỗi lần thay đổi combo box load lại classList
        }

        private void btnInsert_Click(object sender, EventArgs e) // hàm đăng kí 
        {
            string classtypeid = "";
            string classid = "";
            foreach (ClassType ct in cbClassType.Items)
            {
                if (ct.ClassType_Name.Equals(cbClassType.Text.ToString()))
                    classtypeid = ct.ID_ClassType; // lấy ra id loại lớp
            }

            foreach (SClass cl in cbClass.Items)
            {
                if (cl.ClassName.Equals(cbClass.Text.ToString()))
                    classid = cl.IDClass; // lẫy mã lớp
            }
            if (numFee.Value == 0) // kiểm tra đã nhập học phí chưa
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// đăng kí cho học sinh cũ gọi hàm đăng kí 
                if (dbRegister.RegisterForOldStudent(txtIDStudent.Text, classid, cbStudyingTime.Text.ToString(),
                    cbDate1.Text.ToString(), cbDate2.Text.ToString(), classtypeid, numFee.Value.ToString()))
                {
                    MessageBox.Show("Đăng ký lớp thành công kiểm tra lại trong cửa sổ Điểm đầu vào Học viên", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký lớp thất bại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // quay trở lại form trc input point 
        {
            Panel pnlManage = this.Parent as Panel;
            int point = dbInputExam.GetPointStudent(txtIDStudent.Text.ToString());
            if (pnlManage != null)
            {
                UserControlInsertInputPoint insertinputPointControlUser = new UserControlInsertInputPoint();
                insertinputPointControlUser.GetInfo(txtIDStudent.Text, txtStudentName.Text, point);
                pnlManage.Controls.Clear();
                pnlManage.Controls.Add(insertinputPointControlUser);
                insertinputPointControlUser.Dock = DockStyle.Fill;
            }
        }
    }
}
