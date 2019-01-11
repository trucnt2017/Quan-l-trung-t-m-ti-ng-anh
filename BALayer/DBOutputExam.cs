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
    public class DBOutputExam
    {
        DAL db;

        public DBOutputExam()
        {
            db = new DAL();
        }

        public List<OutputExam> GetListOutputExamByClass(string classid) // hàm lấy về danh sách học viên thi đầu ra theo mã lớp
        {
            List<OutputExam> list = new List<OutputExam>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListOutputExamByClass", CommandType.StoredProcedure, // gọi truy vấn stored
                new SqlParameter("@classid",classid));
            foreach (DataRow row in dt.Rows)
            {
                OutputExam oe = new OutputExam(row);
                list.Add(oe);
            }
            return list; // hàm trả về 1 list
        }

        public bool UpdateOutputExam(string studenid, string classid, int point) // hàm cập nhật điểm thi đầu ra
        {
            string error = "Lỗi truy vấn";
            // gọi lệnh truy vấn update thực hiện trigger để cập nhật điểm + cập nhật trạng thái thi
            return db.MyExecuteNonQuery("UPDATE OUTPUT_EXAM SET Point = @point WHERE ID_Student = @studentid AND ID_Class = @classid",
                CommandType.Text, ref error, new SqlParameter("@point", point),
                new SqlParameter("@studentid", studenid), new SqlParameter("@classid", classid)); // hàm trả về true false
        }

        public int CheckProcessPointEqualZero(string studentid, string classid) // hàm kiểm tra các cột điểm của học viên có cột = 0
        {
            return db.MyExecuteScalar("SELECT dbo.CheckProcessPointEqualZero('" + @studentid + "','" + @classid + "')", CommandType.Text,
                new SqlParameter("@studentid",studentid),new SqlParameter("@classid",classid)); // hàm trả về số có bao nhiêu hoặc không
        }
    }
}
