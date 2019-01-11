using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BALayer
{
    public class SClass // model lớp học
    {
        
        string idClass;
        string className;
        int total;
        string studyingTime;
        string date1;
        string date2;
        int syear;
        int semester;
        string classTypeId;
        string classTypeName;
        string classLevelId;
        string classLevelName;
        int classLevel;

        public SClass(string idClass,string className,int total,string studyingTime,string date1,string date2,
        int syear,int semester,string classTypeId,string classTypeName,string classLevelId,string classLevelName,int classLevel)
        {
            this.idClass = idClass;
            this.className = className;
            this.total = total;
            this.studyingTime = studyingTime;
            this.date1 = date1;
            this.date2 = date2;
            this.syear = syear;
            this.semester = semester;
            this.classTypeId = classTypeId;
            this.classTypeName = classTypeName;
            this.classLevelId = classLevelId;
            this.classLevelName = classLevelName;
            this.classLevel = classLevel;
        }

        //ID_Class,Class_Name,Total,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear,Semester,CLASS.ID_ClassType,ClassType_Name,
        //CLASS.ID_ClassLevel,ClassLevel_Name,Class_Level
        public SClass(DataRow row)
        {
            this.idClass = row["ID_Class"].ToString();
            this.className = row["Class_Name"].ToString();
            this.total = int.Parse(row["Total"].ToString());
            this.studyingTime = row["Studying_Time"].ToString();
            this.date1 = row["Date_of_Week_1"].ToString();
            this.date2 = row["Date_of_Week_2"].ToString();
            this.syear = int.Parse(row["SYear"].ToString());
            this.semester = int.Parse(row["Semester"].ToString());
            this.classTypeId = row["ID_ClassType"].ToString();
            this.classTypeName = row["ClassType_Name"].ToString();
            this.classLevelId = row["ID_ClassLevel"].ToString();
            this.classLevelName = row["ClassLevel_Name"].ToString();
            this.classLevel = int.Parse(row["Class_Level"].ToString());
        }

        public string IDClass {
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
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
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
        public int SYear
        {
            get
            {
                return syear;
            }
            set
            {
                syear = value;
            }
        }
        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        public string ClassTypeID
        {
            get
            {
                return classTypeId;
            }
            set
            {
                classTypeId = value;
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
        public int ClassLevel
        {
            get
            {
                return classLevel;
            }
            set
            {
                classLevel = value;
            }
        }
    }
}
