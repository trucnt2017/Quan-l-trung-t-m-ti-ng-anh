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
    public class OldStudent  // model học viên đã đăng kí ở trung tâm
    {
        string studentID;
        string studentName;
        string classID;
        string className;
        string classTypeID;
        string classTypeName;
        string classLevelId;
        string classLevelName;
        int countStudied;

        public OldStudent(string studentID,string studentName,string classID,string className,string classTypeID,string classTypeName,
            string classLevelId,string classLevelName,int countStudied)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.classID = classID;
            this.className = className;
            this.classTypeID = classTypeID;
            this.classTypeName = classTypeName;
            this.classLevelId = classLevelId;
            this.classLevelName = classLevelName;
            this.countStudied = countStudied;
        }

        public OldStudent(DataRow row)
        {
            this.studentID = row["ID_Student"].ToString();
            this.studentName = row["Name"].ToString();
            this.classID = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.classTypeID = row["ID_ClassType"].ToString();
            this.classTypeName = row["ClassType_Name"].ToString();
            this.classLevelId = row["ID_ClassLevel"].ToString();
            this.classLevelName = row["ClassLevel_Name"].ToString();
            this.countStudied = int.Parse(row["CountStudied"].ToString());
        }

        public string StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
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

        public string ClassID
        {
            get
            {
                return classID;
            }

            set
            {
                classID = value;
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

        public string ClassTypeID
        {
            get
            {
                return classTypeID;
            }

            set
            {
                classTypeID = value;
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

        public string ClassLevelId
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

        public int CountStudied
        {
            get
            {
                return countStudied;
            }

            set
            {
                countStudied = value;
            }
        }
    }
}
