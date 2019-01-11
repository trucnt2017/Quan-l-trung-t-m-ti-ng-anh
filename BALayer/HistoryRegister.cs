using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class HistoryRegister // model lịch sử đăng kí của học viên
    {
        string idRegister;
        string idClassType;
        string classTypeName;
        string studyingTime;
        string date1;
        string date2;
        string inputDateExam;
        string fee;

        public HistoryRegister(DataRow row)
        {
            this.idRegister = row["ID_Register"].ToString();
            this.idClassType = row["ID_ClassType"].ToString();
            this.classTypeName = row["ClassType_Name"].ToString();
            this.studyingTime = row["Studying_Time"].ToString();
            this.date1 = row["Date_of_Week_1"].ToString();
            this.date2 = row["Date_of_Week_2"].ToString();
            this.inputDateExam = row["Input_Exam_Date"].ToString();
            this.fee = row["Fee"].ToString();
        }

        public string IdRegister
        {
            get
            {
                return idRegister;
            }

            set
            {
                idRegister = value;
            }
        }

        public string IdClassType
        {
            get
            {
                return idClassType;
            }

            set
            {
                idClassType = value;
            }
        }

        public string ClassTypeName
        {
            get
            {
                return classTypeName;
            }

            set
            {
                classTypeName = value;
            }
        }

        public string StudyingTime
        {
            get
            {
                return studyingTime;
            }

            set
            {
                studyingTime = value;
            }
        }

        public string Date1
        {
            get
            {
                return date1;
            }

            set
            {
                date1 = value;
            }
        }

        public string Date2
        {
            get
            {
                return date2;
            }

            set
            {
                date2 = value;
            }
        }

        public string InputDateExam
        {
            get
            {
                return inputDateExam;
            }

            set
            {
                inputDateExam = value;
            }
        }

        public string Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        
    }
}
