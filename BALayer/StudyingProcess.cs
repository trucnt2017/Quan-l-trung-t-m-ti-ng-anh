using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class StudyingProcess // model quá trình học của học viên
    {
        string idStudent;
        string studentName;
        float hardPoint;
        float listening;
        float reading;
        float writing;
        float speaking;
        int sMonth;

        public StudyingProcess(string idStudent,string studentName,float hardPoint,
            float listening,float reading,float writing,float speaking, int sMonth)
        {
            this.idStudent = idStudent;
            this.studentName = studentName;
            this.hardPoint = hardPoint;
            this.listening = listening;
            this.reading = reading;
            this.writing = writing;
            this.speaking = speaking;
            this.sMonth = sMonth;
        }

        public StudyingProcess(DataRow row)
        {
            this.idStudent = row["ID_Student"].ToString();
            this.studentName = row["Name"].ToString();
            this.hardPoint = float.Parse(row["Hard_Point"].ToString());
            this.listening = float.Parse(row["Listening"].ToString());
            this.reading = float.Parse(row["Reading"].ToString());
            this.writing = float.Parse(row["Writing"].ToString());
            this.speaking = float.Parse(row["Speaking"].ToString());
            this.sMonth = int.Parse(row["SMonth"].ToString()); ;
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

        public float HardPoint
        {
            get
            {
                return hardPoint;
            }

            set
            {
                hardPoint = value;
            }
        }

        public float Listening
        {
            get
            {
                return listening;
            }

            set
            {
                listening = value;
            }
        }

        public float Reading
        {
            get
            {
                return reading;
            }

            set
            {
                reading = value;
            }
        }

        public float Writing
        {
            get
            {
                return writing;
            }

            set
            {
                writing = value;
            }
        }

        public float Speaking
        {
            get
            {
                return speaking;
            }

            set
            {
                speaking = value;
            }
        }

        public int SMonth
        {
            get
            {
                return sMonth;
            }

            set
            {
                sMonth = value;
            }
        }
    }
}
