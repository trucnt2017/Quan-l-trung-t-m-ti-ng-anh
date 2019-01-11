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
    public class DBAccount  // lớp DBAccount làm việc với bảng Account
    {
        DAL db = null;

        public DBAccount()
        {
            db = new DAL();
        }

        public int CheckLogin(string username, string password) // hàm kiểm tra đăng nhập 
        {
            return db.MyExecuteScalar("select dbo.checkLogin('"+@username+"','"+@password+"')",  // gọi hàm checkLogin
                CommandType.Text, 
                new SqlParameter("@username", username.ToString()), // thêm biến username
                new SqlParameter("@password", password.ToString()) // thêm biến password
                 );
        }

        public bool ResetPassword(string username)  // hàm reset password : password mặc định 123
        {
            string error = "Lỗi";
            return db.MyExecuteNonQuery("spResetPassword", CommandType.StoredProcedure,ref error, // gọi stored procedure spResetPassword
                new SqlParameter("@username",username.ToString())); // thêm biến username
        }
    }
}
