using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class DBStudent // làm việc với bảng Student
    {
        DAL db = null;

        public DBStudent()
        {
            db = new DAL(); // tạo 1 lớp DAL mới để thực hiện kết nối tới database
        }

        public bool AddRegisterForNewStudent(string id, string name, string gender, string birthday, string phone, string address,
            string studytime, string date1, string date2, string inputtime, string classtypeid, long fee)
        { // hàm thêm học viên + phiếu đăng kí cho lần đăng kí đầu tiên
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spAddNewStudent", CommandType.StoredProcedure, // truyền command text là storedprodure tên spCheckLogin, kiểu truy vấn là StoredProdure
                ref error, // truy vấn stored procedure 
                new SqlParameter("@studentid", id.ToString()),
                new SqlParameter("@studentname", name.ToString()), // thêm tham số
                new SqlParameter("@gender", gender.ToString()),
                new SqlParameter("@birthday", birthday.ToString()),
                new SqlParameter("@phone", phone.ToString()),
                new SqlParameter("@address", address.ToString()),
                new SqlParameter("@studyingtime", studytime.ToString()),
                new SqlParameter("@date1", date1.ToString()),
                new SqlParameter("@date2", date2.ToString()),
                new SqlParameter("@inputdate", inputtime.ToString()),
                new SqlParameter("@classtypeid", classtypeid.ToString()),
                new SqlParameter("@fee", (long)fee)); // truy vấn excute để kiểm tra thêm thanh công hay không
                                                        // lưu ý ở đây có trigger kiểm tra sdt nếu trùng sẽ set cột sdt là NULL trong database
        }

        public List<Student> GetListStudent() // lấy danh sách học viên 
        {
            List<Student> list = new List<Student>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListStudent", CommandType.StoredProcedure); // truy vấn stored procedure
            foreach (DataRow row in dt.Rows)
            {
                Student st = new Student(row);
                list.Add(st);
            }
            return list; // trả về 1 list để đổ vào datalistview
        }

        public List<HistoryRegister> GetListHistoryRegister(string studentID) // lấy lịch sử đăng kí theo mã học viên
        {
            List<HistoryRegister> list = new List<HistoryRegister>();
            DataTable dt = db.ExecuteQueryDataTable("spCheckHistoryRegisterByStudent", CommandType.StoredProcedure,
                new SqlParameter("@studentID",studentID));
            foreach (DataRow row in dt.Rows)
            {
                HistoryRegister st = new HistoryRegister(row);
                list.Add(st);
            }
            return list;
        }

        public List<HistoryClass> GetListHistoryClass(string studentID) // lấy lịch sử đăng kí lớp học theo mã học viên
        {
            List<HistoryClass> list = new List<HistoryClass>();
            DataTable dt = db.ExecuteQueryDataTable("spCheckHistoryClassByStudent", CommandType.StoredProcedure,
                new SqlParameter("@studentID", studentID));
            foreach (DataRow row in dt.Rows)
            {
                HistoryClass st = new HistoryClass(row);
                list.Add(st);
            }
            return list;
        }

        public List<Student> SearchListStudent(string text) // hàm tìm kiểm theo sự kiện textchange của textbox
        {
            List<Student> list = new List<Student>();
            DataTable dt = db.ExecuteQueryDataTable("spSearchListStudent", CommandType.StoredProcedure,
                new SqlParameter("@text", text));
            foreach (DataRow row in dt.Rows)
            {
                Student st = new Student(row);
                list.Add(st);
            }
            return list;
        }

        public bool EditStudent(string id, string name, string gender, string birthday, string phone, string address) // hàm chỉnh sửa thông tin học viên
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spEditStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@id", id.ToString()),
                new SqlParameter("@name", name.ToString()), // thêm tham số
                new SqlParameter("@gender", gender.ToString()),
                new SqlParameter("@birthday", birthday.ToString()),
                new SqlParameter("@phone", phone.ToString()),
                new SqlParameter("@address", address.ToString())); // trả về thực hiện dc hay không true false
        }
    }
}
