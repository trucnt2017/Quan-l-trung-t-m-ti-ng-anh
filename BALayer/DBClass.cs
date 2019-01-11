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
    public class DBClass // lớp làm việc với bảng Class
    {
        DAL db;
        public DBClass()
        {
            db = new DAL();
        }

        public List<SClass> GetListClass(string classType) // lấy danh sách lớp theo mã loại lớp
        {
            List<SClass> list = new List<SClass>(); // tạo list
            DataTable dt = db.ExecuteQueryDataTable("spGetListClass", CommandType.StoredProcedure, // truy vấn stored
                new SqlParameter("@classtypeid",classType));
            foreach (DataRow row in dt.Rows) // gọi các hàng trong bảng lấy về được
            {
                SClass cl = new SClass(row); // thêm hàng đó vào theo kiểu SClass
                list.Add(cl); // thêm vào list
            }
            return list;
        }

        public List<SClass> GetListClassInProcess() // lấy danh sách lớp trong usercontrol StudyingProcess
        {
            List<SClass> list = new List<SClass>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListClassInProcess", CommandType.StoredProcedure); // truy vấn stored
            foreach (DataRow row in dt.Rows)
            {
                SClass cl = new SClass(row);
                list.Add(cl);
            }
            return list;
        }

        public bool AddClass(string id, string name, string classtypeid, string classlevelid, string time, 
            string date1, string date2)
        { // hàm thêm lớp học vào bảng lớp học
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spAddClass", CommandType.StoredProcedure, ref error, // truy vấn stored spAddClass
                new SqlParameter("@idclass", id),
                new SqlParameter("@className", name),
                new SqlParameter("@studyingTime", time),
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2),
                new SqlParameter("idclasstype", classtypeid),
                new SqlParameter("@idclasslevel", classlevelid));
        }

        public bool EditClass(string id, string name, string classtypeid, string classlevelid, string time, string date1, string date2)
        { // hàm chỉnh sửa thông tin lớp học
            string error = "Lỗi truy cập";
            return db.MyExecuteNonQuery("spEditClass",CommandType.StoredProcedure, ref error, // gọi stored spEditClass
                new SqlParameter("@idclass", id),
                new SqlParameter("@className", name),
                new SqlParameter("@studyingTime", time),
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2),
                new SqlParameter("idclasstype", classtypeid),
                new SqlParameter("@idclasslevel", classlevelid));
        }

        public bool DeleteClass(string id)
        { // hàm xóa lớp học
            string error = "Lỗi truy cập";
            return db.MyExecuteNonQuery("DELETE CLASS WHERE ID_CLass = @id", CommandType.Text, // gọi lệnh truy vấn xóa
                ref error, new SqlParameter("@id", id));                                      // thực hiện trigger kiểm tra xóa lớp được không
        }

        public List<SClass> GetListClassForReRegister(string studentid, string classtypeid, string classlevelid, string studyingtime, string date1, string date2)
        { // lấy danh sách lớp cho việc đăng ký của học sinh cũ
          // lựa chọn combobox lớp học phù hợp sẽ tự load ra (không chọn lại các lớp đã học)
            List<SClass> list = new List<SClass>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListForReRegister", CommandType.StoredProcedure, // truy vấn stored
                new SqlParameter("@studentid",studentid),
                new SqlParameter("@classtypeid", classtypeid),
                new SqlParameter("@classlevelid", classlevelid),
                new SqlParameter("@studyingtime", studyingtime),
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2));
            foreach(DataRow row in dt.Rows)
            {
                SClass sc = new SClass(row);
                list.Add(sc);
            }
            return list;
        }

        public int CountStudentInClass(string classid)   // hàm đếm số lượng học sinh trong 1 lớp
        {
            return db.MyExecuteScalar("select dbo.CountStudentInClass('" + @classid + "')",
                CommandType.Text,
                new SqlParameter("@classid", classid));
        }
    }
}
