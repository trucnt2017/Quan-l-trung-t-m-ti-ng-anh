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
    public partial class UserControlProcess : UserControl
    {
        float hardPoint = 0;
        DBClass dbClass;
        DBStudyingProcess dbStudyingProcess;

        BindingSource classList = new BindingSource(); 

        public UserControlProcess()
        {
            InitializeComponent();
            dbClass = new DBClass();
            dbStudyingProcess = new DBStudyingProcess();
        }

        private void btnInsertProcessPoint_Click(object sender, EventArgs e) // xử lý nút thêm điểm quá trỉnh
        {
            string classid = "";
            int smonth = int.Parse(cbMonth.Text.ToString()); // lấy tháng ở combo box
            foreach (SClass sc in cbClassList.Items)
            {
                if (sc.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = sc.IDClass; // lấy mã lớp học
                }
            }
            if (dbStudyingProcess.UpdateSkillPoint(classid, dtgvStudyingProcess.CurrentRow.Cells[0].Value.ToString(), smonth,
                int.Parse(dtgvStudyingProcess.CurrentRow.Cells[3].Value.ToString()),
                int.Parse(dtgvStudyingProcess.CurrentRow.Cells[4].Value.ToString()),
                int.Parse(dtgvStudyingProcess.CurrentRow.Cells[5].Value.ToString()),
                int.Parse(dtgvStudyingProcess.CurrentRow.Cells[6].Value.ToString())))
                // hàm lưu điểm quá trình qua BAL Studying Process
            {
                MessageBox.Show("Cập nhật điểm quá trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListStudyingProcess(); // load lại danh sách quá trình học
            }
            else
            {
                MessageBox.Show("Cập nhật điểm quá trình thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadListStudyingProcess(); // load lại danh sách quá trình học
            }
        }

        public void LoadClassList() // load danh sách lớp học ban đầu
        {
            classList.DataSource = dbClass.GetListClassInProcess(); // lấy source gán cho bidning source
            if (classList.Count == 0) // nếu chưa có lớp
            {
                MessageBox.Show("Chưa có danh sách lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // đã có lớp
            {
                cbMonth.SelectedIndex = 0;
                cbClassList.DataSource = classList; // gán source cho combo box
                cbClassList.DisplayMember = "ClassName"; // hiển thị theo tên lớp               
                string classid = "";
                int smonth = int.Parse(cbMonth.Text.ToString()); // chọn tháng
                foreach (SClass sc in cbClassList.Items)
                {
                    if (sc.ClassName.Equals(cbClassList.Text.ToString()))
                    {
                        classid = sc.IDClass; // lấy mã lớp học
                    }
                }
                if (dbStudyingProcess.GetListStudyingProcess(classid, smonth).Count > 0)
                    // kiểm tra xem có danh sách quá trình học hay không
                {
                    dtgvStudyingProcess.DataSource = dbStudyingProcess.GetListStudyingProcess(classid, smonth);
                    // load danh sách này ra và đổ vào data gridview
                }
                else
                {
                    dtgvStudyingProcess.DataSource = dbStudyingProcess.GetListStudyingProcess(classid, smonth);
                    // load danh sách này ra và đổ vào data gridview
                }
            }
            
        }

        public void LoadListStudyingProcess() // load danh sách quá trình học
        {
            string classid = "";
            int smonth = int.Parse(cbMonth.Text.ToString()); // chọn tháng
            foreach (SClass sc in cbClassList.Items)
            {
                if (sc.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = sc.IDClass; // lấy mã lớp học
                }
            }
            if (dbStudyingProcess.GetListStudyingProcess(classid, smonth).Count > 0)
            {
                dtgvStudyingProcess.DataSource = dbStudyingProcess.GetListStudyingProcess(classid, smonth);
            }
            else
            {
                dtgvStudyingProcess.DataSource = dbStudyingProcess.GetListStudyingProcess(classid, smonth);
            }
        }
        private void btnHardPoint_Click(object sender, EventArgs e) // hàm lưu điểm chuyên cần học viên
        {
            string classid = "";
            int smonth = int.Parse(cbMonth.Text.ToString()); // chọn tháng
            foreach (SClass sc in cbClassList.Items)
            {
                if (sc.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = sc.IDClass; // lấy mã lớp học
                }
            }
            try
            {
                hardPoint = int.Parse(dtgvStudyingProcess.CurrentRow.Cells[2].Value.ToString());
                if(hardPoint< 0 || hardPoint >30)
                { // kiểm tra nhập điểm quá trình đúng chưa
                    MessageBox.Show("Chưa nhập thành công điểm nhập phải từ 0 đến 30!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                else
                { // nếu từ 0 => 30
                    if (dbStudyingProcess.UpdateHardPoint(classid, dtgvStudyingProcess.CurrentRow.Cells[0].Value.ToString()
                    , smonth, hardPoint))
                    // insert điểm đó vào database qua lớp BAL hàm UpdateHardPoint
                    {
                        MessageBox.Show("Đã nhập điểm chuyên cần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListStudyingProcess(); // load lại dnah sách quá trình học
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập thành công điểm nhập phải từ 0 đến 30!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListStudyingProcess(); // load lại dnah sách quá trình học
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nhập không phải số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void UserControlProcess_Load(object sender, EventArgs e)
        {
            
            LoadClassList(); // load danh sách lớp ban đầu khi load user control
        }

        private void cbClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListStudyingProcess(); // khi thay đôi combo box load lại list quá trình học
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListStudyingProcess();  // khi thay đôi combo box load lại list quá trình học
        }
    }
}
