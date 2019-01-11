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
    public class DBRegister
    {
        DAL db;

        public DBRegister()
        {
            db = new DAL();
        }

        public int CheckGraduationForNewRegister(string studentid, string classid) // hàm kiểm tra học viên đã tốt nghiệp 1 lớp hay chưa
        {
            return db.MyExecuteScalar("SELECT dbo.CheckGraduationForNewRegister('" + @studentid + "','" + @classid + "')",
                CommandType.Text,
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@classid", classid)); // hàm trả về 1 có thi, 0 là chưa thi tốt nghiệp
        }

        public OldStudent GetInfoStudent(string studentid, string classid) // hàm lấy thông tin học viên
        {
            DataTable dt = new DataTable();
            dt = db.ExecuteQueryDataTable("spGetInfoStudent", // sử dụng storedprodure để get thông tin học viên
                CommandType.StoredProcedure, 
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@classid", classid)); 
            foreach (DataRow row in dt.Rows)
            {
                return new OldStudent(row); // trả về hàng đầu tiên của học sinh tìm thấy (thông tin học viên cũ đã có)
            }
            return null; // nếu không trả về null
        }

        public bool RegisterForOldStudent(string studentid, string classid, string studyingtime, string date1, string date2,
            string classtypeid, string fee) // hàm đăng kí cho học viên cũ
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spRegisterForOldStudent", CommandType.StoredProcedure, ref error, // truy vấn stored để thêm đơn đăng kí
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@classid", classid),
                new SqlParameter("@studyingtime", studyingtime),
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2),
                new SqlParameter("@classtypeid", classtypeid),
                new SqlParameter("@fee", fee));
        }

        public int NumberOfRegisterByID(string studentID) // hàm đếm số lượng học viên đã đăng kí lớp học 
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteScalar("SELECT  dbo.countRegisterNumber('" + studentID + "')", CommandType.Text); // truy vấn hàm
        }
    }
}
