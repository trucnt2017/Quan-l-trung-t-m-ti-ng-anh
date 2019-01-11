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
    public class DBClassType // làm việc với bảng ClassType
    {
        DAL db = null;

        public DBClassType()
        {
            db = new DAL();
        }

        public List<ClassType> GetListClassType() // lấy ra danh sách loại lớp học
        {
            List<ClassType> list = new List<ClassType>();
            DataTable dt = db.ExecuteQueryDataTable("spGetListClassType", CommandType.StoredProcedure); // thực hiện truy vấn stored
            foreach(DataRow row in dt.Rows)
            {
                ClassType ct = new ClassType(row); // tạo 1 đối tượng classtype với constructor là row lấy ra từ datatable
                list.Add(ct);
            }
            return list;
        }

        public bool AddClassType(string id, string name) // thêm loại lớp học
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spAddClassType", CommandType.StoredProcedure, // truy vấn stored
                ref error, new SqlParameter("@idClassType", id.ToString()),
                new SqlParameter("@classTypeName", name.ToString()));
        }

        public bool EdiClassType(string id, string name) // hàm chỉnh sửa loại lớp học
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("spEditClassType", CommandType.StoredProcedure,
                ref error, new SqlParameter("@idClassType", id.ToString()),
                new SqlParameter("@classTypeName", name.ToString()));
        }

        public bool DeleteClassType(string id) // hàm xóa loại lớp
        {
            string error = "Lỗi truy vấn";
            return db.MyExecuteNonQuery("DELETE CLASSTYPE WHERE ID_CLassType = @id", CommandType.Text, // thực hiện lệnh truy vấn delete trên bảng
                // ClassType thực hiện trigger kiểm tra có lớp đang mở hay không để tiến hành xóa
                ref error, new SqlParameter("@id", id));
        }

    }
}
