using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class ClassShow  // model show thông tin lớp học trạng thái, ngày nhận lớp
    {
        string idClass;
        string className;
        string status;
        string dateReceive;

        public ClassShow(string idClass, string className, string status, string dateReceive)
        {
            this.idClass = idClass;
            this.className = className;
            this.status = status;
            this.dateReceive = dateReceive;
        }

        public ClassShow(DataRow row)
        {
            this.idClass = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.status = row["SStatus"].ToString();
            this.dateReceive = row["Date_Receive"].ToString();
        }

        public string IDClass
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

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string DateReceive
        {
            get
            {
                return dateReceive;
            }
            set
            {
                dateReceive = value;
            }
        }
    }
}
