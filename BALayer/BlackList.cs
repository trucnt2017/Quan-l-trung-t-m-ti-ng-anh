using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class BlackList // model black list danh sach hạn chế vì bỏ thi
    {
        string idBlackList;
        string idStudent;
        string studentName;
        string idClass;
        string className;
        string reason;

        public BlackList(DataRow row)
        {
            this.idBlackList = row["ID_BlackList"].ToString();
            this.idStudent = row["ID_Student"].ToString();
            this.studentName = row["Name"].ToString();
            this.idClass = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.reason = row["Reason"].ToString();
        }

        public string IdBlackList
        {
            get
            {
                return idBlackList;
            }

            set
            {
                idBlackList = value;
            }
        }

        public string IdStudent
        {
            get
            {
                return idStudent;
            }

            set
            {
                idStudent = value;
            }
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }
        }

        public string IdClass
        {
            get
            {
                return idClass;
            }

            set
            {
                idClass = value;
            }
        }

        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
            }
        }

        public string Reason
        {
            get
            {
                return reason;
            }

            set
            {
                reason = value;
            }
        }
    }
}
