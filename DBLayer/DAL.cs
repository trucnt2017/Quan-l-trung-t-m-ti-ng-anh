using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DBLayer
{
    // lớp này chủ yếu làm việc với cơ sở dữ liệu mở đóng kết nối và các hàm truy vấn trả về dữ liệu
    public class DAL  // Database Access Layer truy cập cơ sở dữ liệu
    {
        static string ip = "";
        static string user = "";
        static string pass = "";
        string ConnStr = "";
        //string ConnStr = @"Server=(local);Database=QuanLyHocVienTrungTam3;
        //                            User Id=sa;Password=03091997;";
        static SqlConnection conn = null;
        static SqlCommand comm = null;
        static SqlDataAdapter da = null;


        public DAL(string ipGet, string userGet, string passGet)
        {
            ip = ipGet;
            user = userGet;
            pass = passGet;
        }

        public bool checkConnect()
        {
            ConnStr = @"Server=" + ip + ";Database=EEEnglish;User Id=" + user + ";Password=" + pass + ";";
            bool flag = false;
            try
            {
                conn = new SqlConnection(ConnStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    flag = true;
            }
            catch(Exception e)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public DAL()
        {
            //ConnStr = @"Server=(local);Database=EEEnglish;User Id=sa;Password=03091997;";
            ConnStr = @"Server=" + ip + ";Database=EEEnglish;User Id=" + user + ";Password=" + pass + ";";
            conn = new SqlConnection(ConnStr); // tạo kết nối với string kết nối
            comm = conn.CreateCommand(); // tạo lệnh truy vấn 
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p) // phương thức trả về là 1 DataSet
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL; // kiểu câu lệnh truy vấn là text
            comm.CommandType = ct; // command type là kiểu truy vấn dạng câu lệnh hoặc storedprodure
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet(); // tạo 1 dataset mới
            da.Fill(ds); // đưa dữ liệu lấy được vào dataset vừa tạo 
            return ds;
        }

        public DataTable ExecuteQueryDataTable(string strSQL, CommandType ct, params SqlParameter[] param)  // phương thức trả về 1 Table
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable(); // tạo 1 data table mới
            da.Fill(dt); // đưa dữ liệu truy vấn được vào table 
            return dt; // trả về 1 data table 
        }


        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param) // trả về kiểu bool 
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL; // ví dụ là storedprodure thì đọc tên của sp đó
            comm.CommandType = ct; // kiểu truy vấn là storedprodure 
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p); // thêm tham số cho câu lệnh truy vấn 
            try
            {
                int temp = 0;
                temp = comm.ExecuteNonQuery();
                if (temp > 0) // kiểm tra nếu có kết quả truy vấn 
                    f = true; // thì trả về true
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public int MyExecuteScalar(string strSQL, CommandType ct, params SqlParameter[] param) // truy vấn scalar trả về kiểu là object nhưng
                                                                                                                 // có thể ép về kiểu int
        {
            string error = "";
            int temp = -1;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                temp = (int)comm.ExecuteScalar(); // nếu truy vấn có kết quả trả về 1 số int dòng đầu, cột đầu của bảng lấy ra
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return temp;
        }

    }
}
