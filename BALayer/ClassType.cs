using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BALayer
{
    public class ClassType // model loại lớp học
    {
        string id_ClassType;
        string classType_Name;

        public ClassType(string id_ClassType, string classType_Name)
        {
            this.id_ClassType = id_ClassType;
            this.classType_Name = classType_Name;
        }

        public ClassType(DataRow row)
        {
            this.id_ClassType = row["ID_ClassType"].ToString();
            this.classType_Name = row["ClassType_Name"].ToString();
        }
        public string ID_ClassType
        {
            get
            {
                return id_ClassType;
            }
            set
            {
                id_ClassType = value;
            }
        }

        public string ClassType_Name
        {
            get
            {
                return classType_Name;
            }
            set
            {
                classType_Name = value;
            }
        }
    }
}
