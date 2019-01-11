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
    public class InputExam // model điểm thi đầu vào của học viên
    {
        string id_Student;
        int point;

        public InputExam(string id_Student, int point)
        {
            this.id_Student = id_Student;
            this.point = point;
        }

        public InputExam(DataRow row)
        {
            this.point = int.Parse(row["Point"].ToString());
            this.id_Student = row["ID_Student"].ToString();           
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

        public string ID_Student
        {
            get
            {
                return id_Student;
            }
            set
            {
                id_Student = value;
            }
        }

        
    }
}
