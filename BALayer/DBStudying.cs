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
    public class DBStudying
    {
        DAL db;
        public DBStudying()
        {
            db = new DAL();
        }

        public List<Studying> GetListClass(string studentid, int point) // hàm lấy danh sách lớp học để load
        {
            List<Studying> list = new List<Studying>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListClassByRegister", CommandType.StoredProcedure, 
                                                                            // lấy danh sách lớp theo lựa chọn ở combo box ở usercontrol đăng kí
                new SqlParameter("@studentid", studentid), // thêm tham số
                new SqlParameter("@point", point));
            foreach (DataRow row in dt.Rows)
            {
                Studying st = new Studying(row);
                list.Add(st);
            }
            return list; // trả về 1 list
        }

        public bool PickClassForStudentByRegister(string studentid, string classid) // hàm chọn lớp cho học viên 
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spPickClass", // nếu có lớp phù hợp thì gọi truy vần stored procedure
                CommandType.StoredProcedure, ref error,
                new SqlParameter("@studentid",studentid),
                new SqlParameter("@classid",classid));
        }

        public ClassShow GetClassByStudent(string studentid) // hàm trả về 1 lớp để hiển thị
        {
            DataTable dt = new DataTable();
            dt = db.ExecuteQueryDataTable("spGetClassByStudent", // sử dụng storedprodure để get lớp học theo mã học viên
                CommandType.StoredProcedure, new SqlParameter("@studentid", studentid)); // truy vấn trả về 1 data table 


            foreach (DataRow row in dt.Rows)
            {
                return new ClassShow(row);  // nếu có thông tin lớp thì trả về hàng đầu tiên
            }
            return null; // nếu không trả về null
        }
    }
}
