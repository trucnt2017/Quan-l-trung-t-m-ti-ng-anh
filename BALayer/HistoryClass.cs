using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class HistoryClass // model lịch sử các lớp học viên đã học, điểm thi và trạng thái thi
    { 
        string idClass;
        string className;
        string sStatus;
        string dateReceive;
        string studyingTimeClass;
        string point;
        string graduation;

        public HistoryClass(DataRow row)
        {
            this.idClass = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.sStatus = row["SStatus"].ToString();
            this.dateReceive = row["Date_Receive"].ToString();
            this.studyingTimeClass = row["Studying_Time"].ToString();
            this.point = row["Point"].ToString();
            this.graduation = row["Graduation"].ToString();
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

        public string SStatus
        {
            get
            {
                return sStatus;
            }

            set
            {
                sStatus = value;
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

        public string StudyingTimeClass
        {
            get
            {
                return studyingTimeClass;
            }

            set
            {
                studyingTimeClass = value;
            }
        }

        public string Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public string Graduation
        {
            get
            {
                return graduation;
            }

            set
            {
                graduation = value;
            }
        }
    }
}
