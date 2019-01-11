using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;

namespace StudentManagementApp
{
    public partial class UserControlSetting : UserControl
    {
        DBBlackList dbBlackList;

        BindingSource blackList = new BindingSource();

        public UserControlSetting()
        {
            InitializeComponent();
            dbBlackList = new DBBlackList(); // khai báo lớp BAL
        }

        public void LoadBlackList()
        {
            blackList.DataSource = dbBlackList.GetListBlackList(); // load danh sách hạn chế vào source binding
        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {
            LoadBlackList();
            dtgvBlackList.DataSource = blackList; // gán source cho datagridview
        }
    }
}
