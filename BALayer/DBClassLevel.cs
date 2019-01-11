using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class DBClassLevel // làm việc với bảng ClassLevel
    {
        DAL db;

        public DBClassLevel()
        {
            db = new DAL();
        }

        public List<ClassLevel> GetListClassLevel() // lấy danh sách cấp độ lớp để load ra theo yêu cầu
        {
            List<ClassLevel> list = new List<ClassLevel>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListClassLevel", CommandType.StoredProcedure); // truy vấn stored
            foreach (DataRow row in dt.Rows)
            {
                ClassLevel cl = new ClassLevel(row);
                list.Add(cl);
            }
            return list;
        }
    }
}
