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
    public class DBInputExam
    {
        DAL db;
        public DBInputExam()
        {
            db = new DAL();
        }

        public bool InsertInputPoint(string studentid, float point) // hàm thêm điểm của học viên vào bảng input
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spAddInputPoint", CommandType.StoredProcedure, ref error, // thực hiện truy vấn stored
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@point", point)); // hàm trả về true false thực hiện được hoặc không
        }

        public int GetPointStudent(string studentid) // lấy điểm đầu vào của học viên để load danh sách lớp phù hợp cho lần đăng ký đầu tiên
        {
            int point = 0;
            DataTable dt = db.ExecuteQueryDataTable("spGetPointStudent", CommandType.StoredProcedure, // truy vấn stored
                new SqlParameter("@studentid", studentid.ToString())); // thêm biến studentid vào truy vấn
            foreach (DataRow row in dt.Rows)
            {
                InputExam ie = new InputExam(row);
                point = ie.Point;
                return point;
            }
            return point; // hàm trả về điểm đầu vào của học viên
        }
    }
}
