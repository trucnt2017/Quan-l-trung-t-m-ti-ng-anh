using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class ClassLevel // model cấp độ lớp
    {
        string idClassLevel;
        string classLevelName;
        int classLevelNum;

        public ClassLevel(string idClassLevel,string classLevelName,int classLevelNum)
        {
            this.idClassLevel = idClassLevel;
            this.classLevelName = classLevelName;
            this.classLevelNum = classLevelNum;
        }

        public ClassLevel(DataRow row)
        {
            this.idClassLevel = row["ID_ClassLevel"].ToString();
            this.classLevelName = row["ClassLevel_Name"].ToString();
            this.classLevelNum = int.Parse(row["Class_Level"].ToString());
        }

        public string ID_ClassLevel
        {
            get
            {
                return idClassLevel;
            }
            set
            {
                idClassLevel = value;
            }
        }

        public string ClassLevel_Name
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

        public int Class_Level
        {
            get
            {
                return classLevelNum;
            }
            set
            {
                classLevelNum = value;
            }
        }
    }
}
