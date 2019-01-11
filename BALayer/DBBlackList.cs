using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBLayer;

namespace BALayer
{
    public class DBBlackList // làm việc với bảng sinh viên bỏ thi
    {
        DAL db;

        public DBBlackList()
        {
            db = new DAL();
        }

        public bool AddToBlackList(string studentid, string classid, string reason) // thêm học viên vào danh sách hạn chế có lý do
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spSetBlackList", CommandType.StoredProcedure, ref error,
                new SqlParameter("@studentID", studentid),
                new SqlParameter("@classID", classid),
                new SqlParameter("@reason", reason));
        }

        public List<BlackList> GetListBlackList()  // lấy danh sách hạn chế load ra màn hình
        {
            List<BlackList> list = new List<BlackList>();
            DataTable dt = db.ExecuteQueryDataTable("spGetBlackList", CommandType.StoredProcedure); // truy vấn stored
            foreach (DataRow row in dt.Rows)
            {
                BlackList cl = new BlackList(row);
                list.Add(cl);
            }
            return list;
        }

        public int CheckStudentInBlackList(string studentID) // kiểm tra xem học sinh có trong danh sách hạn chế hay không
        {
            return db.MyExecuteScalar("spCheckExistsInBlackList", CommandType.StoredProcedure,
                new SqlParameter("@studentID", studentID));
        }

        public int CountStudentInBlackList(string studentID, string classID)
        {
            return db.MyExecuteScalar("SELECT dbo.CountStudentInBlackList('"+studentID+"','"+classID+"')", CommandType.Text);
        }
    }
}
