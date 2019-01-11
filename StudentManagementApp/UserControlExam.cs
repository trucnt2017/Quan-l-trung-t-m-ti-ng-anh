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
    public partial class UserControlExam : UserControl
    {
        int outputPoint = 0;
        // khởi tạo các lớp BAL
        DBClass dbClass;
        DBClassType dbClassType;
        DBOutputExam dbOutputExam;
        DBBlackList dbBlackList;
        // khởi tạo các source data cần thiết
        BindingSource classList = new BindingSource();
        BindingSource classTypeList = new BindingSource();
        BindingSource outputExamList = new BindingSource();

        public UserControlExam()
        {
            InitializeComponent();
            // tạo mới lớp BAL
            dbClass = new DBClass();
            dbClassType = new DBClassType();
            dbOutputExam = new DBOutputExam();
            dbBlackList = new DBBlackList();
        }

        public void LoadClassList(string classtypeid)
        {
            classList.DataSource = dbClass.GetListClass(classtypeid); // lấy danh sách loại lớp đưa vào source binding
            cbClassList.DataSource = classList; // gán source cho combo box
            cbClassList.DisplayMember = "ClassName"; // lấy hiển thị theo tên

            string classid = "";
            foreach (SClass ct in cbClassList.Items)
            {
                if (ct.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = ct.IDClass;
                }
            }

            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // gán tasource cho source binding exam
                                                                                       // lấy danh sách lớp theo mã loại lớp
            dtgvOutputExam.DataSource = outputExamList; // gán source vừa get được cho datagridview
        }

        public void LoadClassTypeList() // load danh sách loại lớp
        {
            classTypeList.DataSource = dbClassType.GetListClassType(); // đổ data vào data binding source
                                                                       // gọi hàm get list qua lớp BAL DBClassType
            cbClassType.DataSource = classTypeList; // gán source này cho combo box loại lớp
            cbClassType.DisplayMember = "ClassType_Name"; // hiển thị theo tên loại lớp

            string classtypeid = "";
            foreach (ClassType ct in cbClassType.Items)
            {
                if (ct.ClassType_Name.Equals(cbClassType.Text.ToString()))
                {
                    classtypeid = ct.ID_ClassType; // lấy mã loại lớp
                }
            }
            LoadClassList(classtypeid); // load danh sách lớp học theo mã loại lớp
        }

        private void btnInsertOutputPoint_Click(object sender, EventArgs e) // xử lý nút lưu điểm đầu ra
        {
            string classid = "";
            foreach (SClass ct in cbClassList.Items)
            {
                if (ct.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = ct.IDClass; // lấy mã lớp chạy trong combo box từ source
                }
            }
            if (dbBlackList.CountStudentInBlackList(dtgvOutputExam.CurrentRow.Cells["ID_Student"].Value.ToString(),
                        dtgvOutputExam.CurrentRow.Cells["ID_Class"].Value.ToString()) == 0)
            {
                if (dbOutputExam.CheckProcessPointEqualZero(dtgvOutputExam.CurrentRow.Cells[1].Value.ToString(), classid) == 0)
                // hàm kiểm tra có cột điểm quá trình nào bằng 0 hay không
                {
                    if (MessageBox.Show("Vui lòng kiểm tra lại điểm quá trình có cột điểm 0. Nếu chắc chắc nhấn Yes để tiếp tục?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    // nếu chọn yes dù có cột điểm bằng 0 thì thực thi
                    {
                        if (dbOutputExam.UpdateOutputExam(dtgvOutputExam.CurrentRow.Cells["ID_Student"].Value.ToString(), classid,
                            int.Parse(dtgvOutputExam.CurrentRow.Cells["Point"].Value.ToString())))
                        // hàm cập nhật điểm thi (thực thi trigger để tự động lưu điểm + trạng thái )
                        {
                            MessageBox.Show("Cập nhật điểm thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // load lai source
                            dtgvOutputExam.DataSource = outputExamList; // đưa source vào datagridview
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật điểm thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // load lai source
                            dtgvOutputExam.DataSource = outputExamList; // đưa source vào datagridview
                        }
                    }
                    else
                    {
                        // nếu chọn không chỉ cần load lại source và datagridview
                        outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                        dtgvOutputExam.DataSource = outputExamList;
                    }
                }
                else
                {
                    // nếu không có cột điểm nào bằng 0
                    if (dbOutputExam.UpdateOutputExam(dtgvOutputExam.CurrentRow.Cells["ID_Student"].Value.ToString(), classid,
                        int.Parse(dtgvOutputExam.CurrentRow.Cells["Point"].Value.ToString())))
                    // hàm cập nhật điểm bình thường thông qua lớp BAL
                    {
                        MessageBox.Show("Cập nhật điểm thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                        dtgvOutputExam.DataSource = outputExamList;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật điểm thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                        dtgvOutputExam.DataSource = outputExamList;
                    }
                }
            }
            else
            {
                MessageBox.Show("Học viên đã bỏ thi không thể cập nhật lại điểm cho học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                dtgvOutputExam.DataSource = outputExamList;
            }
        }

        private void UserControlExam_Load(object sender, EventArgs e)
        {
            LoadClassTypeList(); // load loại lớp khi mới load user control
        }

        private void cbClassType_SelectedIndexChanged(object sender, EventArgs e)// khi thay đổi selected combo box
        {
            string classtypeid = "";
            foreach (ClassType ct in cbClassType.Items)
            {
                if (ct.ClassType_Name.Equals(cbClassType.Text.ToString()))
                {
                    classtypeid = ct.ID_ClassType; // lấy ra mã loại lớp
                }
            }
            classList.DataSource = dbClass.GetListClass(classtypeid); // load danh sách lớp theo loại lớp qua BAL Class
            cbClassList.DataSource = classList; // đưa source vào combo box
            cbClassList.DisplayMember = "ClassName"; // hiển thị theo tên lớp

            string classid = "";
            foreach (SClass ct in cbClassList.Items)
            {
                if (ct.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = ct.IDClass; // lấy ra mã lớp học
                }
            }

            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // lấy danh sách thi đầu ra theo mã lớp học
            dtgvOutputExam.DataSource = outputExamList; // đưa danh sách này vào datagridview

        }

        private void cbClassList_SelectedIndexChanged(object sender, EventArgs e) // xử lý tương tự với thay đổi selected class
        {
            string classid = "";
            foreach (SClass ct in cbClassList.Items)
            {
                if (ct.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = ct.IDClass; // lấy ra mã lớp
                }
            }

            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // lấy danh sách điểm thi theo lớp
            dtgvOutputExam.DataSource = outputExamList; // đưa source vào data gridview
        }

        private void dtgvOutputExam_CellContentClick(object sender, DataGridViewCellEventArgs e) 
            // xử lý sự kiện nhấn nút "Bỏ thi"
        {
            string classid = "";
            foreach (SClass ct in cbClassList.Items)
            {
                if (ct.ClassName.Equals(cbClassList.Text.ToString()))
                {
                    classid = ct.IDClass; // lấy mã lớp hiện đang chọn
                }
            }
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0) // nếu có sự kiện click trên button trong datagridview
            {
                try
                {
                    if (dbBlackList.CountStudentInBlackList(dtgvOutputExam.Rows[e.RowIndex].Cells["ID_Student"].Value.ToString(),
                        dtgvOutputExam.Rows[e.RowIndex].Cells["ID_Class"].Value.ToString()) == 0)
                    {
                        if (dbBlackList.AddToBlackList(dtgvOutputExam.Rows[e.RowIndex].Cells["ID_Student"].Value.ToString(),
                            dtgvOutputExam.Rows[e.RowIndex].Cells["ID_Class"].Value.ToString(), "Bỏ thi"))
                        // đưa học sinh đó vào danh sách hạn chế
                        {
                            MessageBox.Show("Xác nhận sinh viên bỏ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid); // load lại danh sách điểm thi
                            dtgvOutputExam.DataSource = outputExamList;
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi trong quá trình gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                            dtgvOutputExam.DataSource = outputExamList;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xác nhận sinh viên bỏ thi trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        outputExamList.DataSource = dbOutputExam.GetListOutputExamByClass(classid);
                        dtgvOutputExam.DataSource = outputExamList;
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
