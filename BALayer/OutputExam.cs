using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class OutputExam // model bảng đầu ra của trung tâm
    {
        string idClass;
        string idStudent;        
        string studentName;
        int point;
        string graduation;

        public OutputExam(string idClass, string idStudent, string studentName, int point, string graduation)
        {
            this.idClass = idClass;
            this.idStudent = idStudent;           
            this.studentName = studentName;
            this.point = point;
            this.graduation = graduation;
        }

        public OutputExam(DataRow row)
        {
            this.idClass = row["ID_Class"].ToString();
            this.idStudent = row["ID_Student"].ToString();
            this.studentName = row["Name"].ToString();           
            this.point = int.Parse(row["Point"].ToString());
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

        public int Point
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
