using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class Studying // model bảng liên kết giữa học viên và lớp học
    {
        string idClass;
        string className;
        string classLevelId;
        string classLevelName;
        string studyingTime;
        string date1;
        string date2;

        public Studying(string idClass, string className, string classLevelId, string classLevelName,
            string studyingTime, string date1, string date2)
        {
            this.idClass = idClass;
            this.className = className;
            this.classLevelId = classLevelId;
            this.classLevelName = classLevelName;
            this.studyingTime = studyingTime;
            this.date1 = date1;
            this.date2 = date2;
        }

        public Studying(DataRow row)
        {
            this.idClass = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.classLevelId = row["ID_ClassLevel"].ToString();
            this.classLevelName = row["ClassLevel_Name"].ToString();
            this.studyingTime = row["Studying_Time"].ToString();
            this.date1 = row["Date_of_Week_1"].ToString();
            this.date2 = row["Date_of_Week_2"].ToString();
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

        public string ClassLevelID
        {
            get
            {
                return classLevelId;
            }
            set
            {
                classLevelId = value;
            }
        }
        public string ClassLevelName
        {
            get
            {
                return classLevelName;
            }
            set
            {
                classLevelName = value;
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
    }
}
