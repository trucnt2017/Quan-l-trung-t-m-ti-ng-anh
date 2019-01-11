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

    public class DBStudyingProcess // class làm việc với bảng StudyingProcess
    {
        DAL db;

        public DBStudyingProcess()
        {
            db = new DAL();

        }

        // hàm lấy danh sách quá trình học theo lớp học và theo tháng
        public List<StudyingProcess> GetListStudyingProcess(string classid, int smonth) 
        {
            List<StudyingProcess> list = new List<StudyingProcess>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListStudyingProcess", CommandType.StoredProcedure, // truy vấn stored procedure
                new SqlParameter("@classid", classid),
                new SqlParameter("@smonth", smonth));
            foreach (DataRow row in dt.Rows)
            {
                StudyingProcess sp = new StudyingProcess(row);
                list.Add(sp);
            }
            return list; // trả về 1 list
        }

        public bool UpdateHardPoint(string classid, string studentid, int sMonth, float hardPoint) // hàm cập nhật điểm chuyên cần học viên
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spUpdateHardPoint", CommandType.StoredProcedure,
                ref error, new SqlParameter("@classid", classid), 
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@smonth", sMonth),
                new SqlParameter("@hardpoint", hardPoint));
        }

        public bool UpdateSkillPoint(string classid, string studentid, int sMonth, int listening,
            int reading, int writing, int speaking) // hàm cập nhật điểm quá trình học viên
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spUpdateSkillPoint", CommandType.StoredProcedure,
                ref error, new SqlParameter("@classid", classid),
                new SqlParameter("@studentid", studentid),
                new SqlParameter("@smonth", sMonth),
                new SqlParameter("@listening", listening),
                new SqlParameter("@reading", reading),
                new SqlParameter("@writing", writing),
                new SqlParameter("@speaking", speaking));
        }
    }
}
