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
    public partial class UserControlInsertInputPoint : UserControl
    {
        int inputPoint = 0; // điểm đầu vào
        // khởi tạo các lớp BAL cần thiết
        DBInputExam dbInputExam;
        DBStudying dbStudying;
        DBRegister dbRegister;
        DBClass dbClass;
        DBBlackList dbBlackList;

        ClassShow cs;

        BindingSource studyingList = new BindingSource();
        public UserControlInsertInputPoint()
        {
            InitializeComponent();
            dbInputExam = new DBInputExam();
            dbStudying = new DBStudying();
            dbRegister = new DBRegister();
            dbClass = new DBClass();
            dbBlackList = new DBBlackList();
        }

        public void GetInfo(string id, string name, int point) // hàm lấy thông tin từ user control học sinh
        {
            //đưa dữ liệu cho các trường 
            txtID.Text = id;
            txtName.Text = name;
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            inputPoint = point;
            if (inputPoint == 0)
            {
                txtPoint.Text = "Chưa nhập điểm"; // nếu chưa có điểm đầu vào 
            }
            else
            {
                txtPoint.Text = inputPoint.ToString();
            }
        }
        private void btnInsertInputPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStatus.Text == "") // nếu chưa đăng ký lớp lần nào
                {
                    if (dbStudying.PickClassForStudentByRegister(txtID.Text.ToString(), dtgvClassFilter.CurrentRow.Cells[0].Value.ToString()))
                        // đăng ký lớp cho học viên đăng ký lần đầu
                    {
                        MessageBox.Show("Đăng ký lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cs = dbStudying.GetClassByStudent(txtID.Text.ToString()); // lấy lớp theo mã id 
                        if (cs == null) // nếu học sinh chưa có lớp
                        {
                            MessageBox.Show("Chưa xếp lớp cho học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        { // nếu đã có lớp load dữ liệu vào các trường
                            txtClassID.Text = cs.IDClass;
                            txtClassName.Text = cs.ClassName;
                            txtStatus.Text = cs.Status;
                            txtClassID.ReadOnly = true;
                            txtClassName.ReadOnly = true;
                            txtStatus.ReadOnly = true;
                        }
                    }
                    else
                    { // nếu học viên đã đăng ký rồi
                        if (dbClass.CountStudentInClass(dtgvClassFilter.CurrentRow.Cells[0].Value.ToString()) == 10)
                        {
                            MessageBox.Show("Lớp đã đầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Đã học qua lớp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    if(txtStatus.Text == "Thi đạt" || txtStatus.Text == "Thi không đạt") 
                        // kiểm tra học viên đã dki rồi thì nhấn vào form dki cho học viên cũ
                        MessageBox.Show("Nhấn đăng ký cho học viên cũ để đăng ký lớp", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    MessageBox.Show("Học viên chưa thi tốt nghiệp lớp hiện tại không thể đăng ký thêm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đăng ký lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

        private void btnFilter_Click(object sender, EventArgs e) // nút lọc lưu điểm đầu vào nếu chưa có
        {
            try
            {
                if (dbInputExam.InsertInputPoint(txtID.Text.ToString(), int.Parse(txtPoint.Text.ToString())))
                { // lưu điểm thi đầu vào cho học viên
                    MessageBox.Show("Lưu điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studyingList.DataSource = dbStudying.GetListClass(txtID.Text.ToString(), int.Parse(txtPoint.Text.ToString()));
                    dtgvClassFilter.DataSource = studyingList;
                    //dtgvClassFilter.DataSource = dbStudying.GetListClass(txtID.Text.ToString(), inputPoint);
                    // load source từ hàm GetListClass trong BAL Studying đưa vào datagridview
                }
                else
                {
                    MessageBox.Show("Lưu điểm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lưu điểm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadStudyingClass() // load danh sách lớp
        {
            //if(dbRegister.NumberOfRegisterByID(txtID.Text) == 1)
                studyingList.DataSource = dbStudying.GetListClass(txtID.Text.ToString(),inputPoint);
           // else
             //   MessageBox.Show("Nhấn nút đăng ký lớp cho học viên cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UserControlInsertInputPoint_Load(object sender, EventArgs e)
        {
            if(txtPoint.Text != "Chưa nhập điểm") // nếu đã có điểm đẩu vào
            {
                LoadStudyingClass(); // load danh sach lớp phù hợp
                                    // ở đây load theo loại, ngày, giờ học và cấp độ
                                    // xử lý ở database
                dtgvClassFilter.DataSource = studyingList; // load source này vào datagridview
            }
            cs = dbStudying.GetClassByStudent(txtID.Text.ToString()); // lấy ra lớp học nếu đã có điểm thi đầu vào và đã chọn lớp
            if(cs == null)
            {
                MessageBox.Show("Chưa xếp lớp cho học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtClassID.Text = cs.IDClass;
                txtClassName.Text = cs.ClassName;
                txtStatus.Text = cs.Status;
                txtClassID.ReadOnly = true;
                txtClassName.ReadOnly = true;
                txtStatus.ReadOnly = true;
            }
        }

        private void btnReRegister_Click(object sender, EventArgs e) // xử lý nút tái đăng ký cho học viên cũ
        {
            cs = dbStudying.GetClassByStudent(txtID.Text.ToString()); // lấy học viên (vì đã đăng kí và có thông tin)
            if (txtPoint.Text == "Chưa nhập điểm")
            {

                MessageBox.Show("Chưa nhập điểm đầu vào cho học viên", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);               
            }
            else
            {
                try
                {
                    if (dbRegister.CheckGraduationForNewRegister(txtID.Text, cs.IDClass) == 1)
                        // kiểm tra đã tốt nghiệp hay chưa
                    {
                        if (cs.Status == "Thi đạt" || cs.Status == "Thi không đạt" || cs.Status == "Bỏ thi")
                        {
                            if (dbBlackList.CheckStudentInBlackList(txtID.Text) == 1)
                                // kiểm tra sinh viên có trong danh sách hạn chế hay không
                            {
                                if (MessageBox.Show("Sinh viên này nằm trong danh sách hạn chế tiếp tục đăng ký lớp cho sinh viên này?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    // nếu đồng ý đăng kí thì tiếp tục
                                {
                                    // mở user control tái đăng kí để đăng kí
                                    Panel pnlManage = this.Parent as Panel;
                                    if (pnlManage != null)
                                    {
                                        UserControlArrange arrangeControlUser = new UserControlArrange();
                                        arrangeControlUser.GetInfo(txtID.Text, cs.IDClass);
                                        pnlManage.Controls.Clear();
                                        pnlManage.Controls.Add(arrangeControlUser);
                                        arrangeControlUser.Dock = DockStyle.Fill;
                                    }
                                }
                            }
                            else
                            { // ngược lại không có trong danhs sách đen thì mở user control bình thường

                                Panel pnlManage = this.Parent as Panel;
                                if (pnlManage != null)
                                {
                                    UserControlArrange arrangeControlUser = new UserControlArrange();
                                    arrangeControlUser.GetInfo(txtID.Text, cs.IDClass);
                                    pnlManage.Controls.Clear();
                                    pnlManage.Controls.Add(arrangeControlUser);
                                    arrangeControlUser.Dock = DockStyle.Fill;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Học viên chưa thi xét tốt nghiệp lớp học. Không thể đăng ký lớp mới", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Học viên chưa thi xét tốt nghiệp lớp học. Không thể đăng ký lớp mới", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Chưa chọn lớp cho học viên", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
    }
}
