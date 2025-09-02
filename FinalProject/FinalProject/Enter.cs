using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Enter : Form
    {
        Class_LinkOfServer class_LinkOfServer = new Class_LinkOfServer();
        DataTable dataTable = new DataTable();
        Class_LinkOfServer.NameOfFildes[] nameOfFildes;
        SqlDbType[] DataTypes;
        Class_LinkOfServer.NameOfFildes nameOfFilde;
        SqlDbType DataType;
        string[] Datas;
        string Data;
        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == TextBox_Password2.Text)
            {
                nameOfFildes = new Class_LinkOfServer.NameOfFildes[2];
                DataTypes = new SqlDbType[2];
                Datas = new string[2];
                nameOfFildes[0] = Class_LinkOfServer.NameOfFildes.FirstName;
                nameOfFildes[1] = Class_LinkOfServer.NameOfFildes.Passwords;
                DataTypes[0] = SqlDbType.NVarChar;
                DataTypes[1] = SqlDbType.NVarChar;
                Datas[0] = TextBox_Name.Text;
                Datas[1] = TextBox_Password.Text;
                dataTable = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.PrivetSelectOneOfDataOfUsers, nameOfFildes, DataTypes, Datas);
                if (dataTable.Rows.Count != 1)
                {
                    MessageBox.Show("الرجاء التأكد من اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nameOfFilde = Class_LinkOfServer.NameOfFildes.IDType;
                    DataType = SqlDbType.Int;
                    Data = dataTable.Rows[0][5].ToString();
                    Class_Public.NumberOfUser= dataTable.Rows[0][1].ToString();
                    Class_Public.User = dataTable;
                    Class_Public.dataTableOfPropretesOfUser = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectOneOfDataOfDuteiesOfTypes, nameOfFilde, DataType, Data);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = true;
            TextBox_Password2.UseSystemPasswordChar = true;
        }

        private void CheckBox_ControlOfPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ControlOfPassword.Checked == true)
            {
                TextBox_Password.UseSystemPasswordChar = false;
                TextBox_Password2.UseSystemPasswordChar = false;
            }
            else
            {
                TextBox_Password.UseSystemPasswordChar = true;
                TextBox_Password2.UseSystemPasswordChar = true;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
