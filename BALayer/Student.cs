using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class Student // model học viên trung tâm
    {
        string id_student;
        string name;
        string gender;
        string birthday;
        string phoneNumber;
        string sAddress;

        public Student(string id_student,string name,string gender, string birthday, string phoneNumber,string sAddress)
        {
            this.id_student = id_student;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
            this.sAddress = sAddress;
        }

        public Student(DataRow row)
        {
            this.id_student = row["ID_Student"].ToString();
            this.name = row["Name"].ToString();
            this.gender = row["Gender"].ToString();
            this.birthday = row["Birthday"].ToString().Split(' ')[0];
            this.phoneNumber = row["PhoneNumber"].ToString();
            this.sAddress = row["SAddress"].ToString();
        }

        public string ID_Student
        {
            get
            {
                return id_student;
            }
            set
            {
                id_student = value;
            }
        }

        public string StudentName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public string SAddress
        {
            get
            {
                return sAddress;
            }
            set
            {
                sAddress = value;
            }
        }
    }
}
