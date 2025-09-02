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
    public partial class Types : Form
    {
        int Item = 0;
        DataTable dataTableTypes;
        DataTable dataTableDuteiesOfUsers;
        Class_LinkOfServer class_LinkOfServer = new Class_LinkOfServer();
        Class_LinkOfServer.NameOfFildes nameOfFilde;
        SqlDbType DataType;
        Class_LinkOfServer.NameOfFildes[] nameOfFildes;
        SqlDbType[] DataTypes;
        string[] Datas;
        string Data;
        string NumberOfUbdate;
        void TypeOfTools(Boolean Type)
        {
            TextBox_Name.Enabled = Type;
            TextBox_Number.Enabled = Type;
            CheckBox_AddProject.Enabled = Type;
            CheckBox_AddType.Enabled = Type;
            CheckBox_AddUser.Enabled = Type;
            CheckBox_DeleteProject.Enabled = Type;
            CheckBox_DeleteType.Enabled = Type;
            CheckBox_DeleteUser.Enabled = Type;
            CheckBox_ShowProject.Enabled = Type;
            CheckBox_ShowType.Enabled = Type;
            CheckBox_ShowUser.Enabled = Type;
            CheckBox_updateProject.Enabled = Type;
            CheckBox_UpdateType.Enabled = Type;
            CheckBox_UpdateUser.Enabled = Type;
            Button_Close.Enabled = !Type;
            Button_First.Enabled = !Type;
            Button_Last.Enabled = !Type;
            Button_Next.Enabled = !Type;
            Button_Previw.Enabled = !Type;
            Button_Save.Enabled = Type;
            Button_Cancel.Enabled = Type;
            for (int i = 0; i < Class_Public.Propreties.Length; i++)
            {
                if (Class_Public.Propreties[i] == "9")
                {
                    Button_Add.Enabled = !Type;
                }
                else if (Class_Public.Propreties[i] == "10")
                {
                    Button_Update.Enabled = !Type;
                }
                else if (Class_Public.Propreties[i] == "11")
                {
                    Button_Delete.Enabled = !Type;
                }
            }
            if (Class_Public.state == Class_Public.State.Show)
            {
                for (int i = 0; i < dataTableDuteiesOfUsers.Rows.Count; i++)
                {
                    if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "1")
                    {
                        CheckBox_AddUser.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "2")
                    {
                        CheckBox_UpdateUser.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "3")
                    {
                        CheckBox_AddProject.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "4")
                    {
                        CheckBox_updateProject.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "5")
                    {
                        CheckBox_ShowProject.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "6")
                    {
                        CheckBox_DeleteUser.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "7")
                    {
                        CheckBox_ShowUser.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "8")
                    {
                        CheckBox_DeleteProject.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "9")
                    {
                        CheckBox_AddType.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "10")
                    {
                        CheckBox_UpdateType.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "11")
                    {
                        CheckBox_DeleteType.Checked = true;
                    }
                    else if (dataTableDuteiesOfUsers.Rows[i][1].ToString() == "12")
                    {
                        CheckBox_ShowType.Checked = true;
                    }
                }
            }
            else if (Class_Public.state == Class_Public.State.Add)
            {
                CheckBox_AddProject.Checked = false;
                CheckBox_AddType.Checked = false;
                CheckBox_AddUser.Checked = false;
                CheckBox_DeleteProject.Checked = false;
                CheckBox_DeleteType.Checked = false;
                CheckBox_DeleteUser.Checked = false;
                CheckBox_ShowProject.Checked = false;
                CheckBox_ShowType.Checked = false;
                CheckBox_ShowUser.Checked = false;
                CheckBox_updateProject.Checked = false;
                CheckBox_UpdateType.Checked = false;
                CheckBox_UpdateUser.Checked = false;
            }
        }
        void FormLoad()
        {
            Class_Public.state = Class_Public.State.Show;
            nameOfFilde = Class_LinkOfServer.NameOfFildes.IDType;
            DataType = SqlDbType.Int;
            Data = dataTableTypes.Rows[Item][2].ToString();
            dataTableDuteiesOfUsers = new DataTable();
            dataTableDuteiesOfUsers = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectOneOfDataOfDuteiesOfTypes, nameOfFilde, DataType, Data);
            TextBox_Number.Text = dataTableTypes.Rows[Item][2].ToString();
            TextBox_Name.Text = dataTableTypes.Rows[Item][3].ToString();
            CheckBox_AddProject.Checked = false;
            CheckBox_AddType.Checked = false;
            CheckBox_AddUser.Checked = false;
            CheckBox_DeleteProject.Checked = false;
            CheckBox_DeleteType.Checked = false;
            CheckBox_DeleteUser.Checked = false;
            CheckBox_ShowProject.Checked = false;
            CheckBox_ShowType.Checked = false;
            CheckBox_ShowUser.Checked = false;
            CheckBox_updateProject.Checked = false;
            CheckBox_UpdateType.Checked = false;
            CheckBox_UpdateUser.Checked = false;
            TypeOfTools(false);
            Label_PartOfAll.Text = "المستخدم " + (Item + 1).ToString() + " من أصل " + dataTableTypes.Rows.Count.ToString();
        }
        public Types()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_First_Click(object sender, EventArgs e)
        {
            Item = 0;
            FormLoad();
        }

        private void Types_Load(object sender, EventArgs e)
        {
            Button_Add.Enabled = false;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
            dataTableTypes = new DataTable();
            dataTableTypes = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
            FormLoad();
        }

        private void Button_Previw_Click(object sender, EventArgs e)
        {
            if (Item != 0)
            {
                Item -= 1;
                FormLoad();
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (Item != dataTableTypes.Rows.Count - 1)
            {
                Item += 1;
                FormLoad();
            }
        }

        private void Button_Last_Click(object sender, EventArgs e)
        {
            Item = dataTableTypes.Rows.Count - 1;
            FormLoad();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Class_Public.state = Class_Public.State.Add;
            TypeOfTools(true);
            TextBox_Name.Text = "";
            TextBox_Number.Text = "";
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            Class_Public.state = Class_Public.State.Update;
            TypeOfTools(true);
            if (dataTableTypes.Rows[Item][1].ToString() == "1" || dataTableTypes.Rows[Item][1].ToString() == Class_Public.User.Rows[0][5].ToString())
            {
                CheckBox_AddProject.Enabled = false;
                CheckBox_AddType.Enabled = false;
                CheckBox_AddUser.Enabled = false;
                CheckBox_DeleteProject.Enabled = false;
                CheckBox_DeleteType.Enabled = false;
                CheckBox_DeleteUser.Enabled = false;
                CheckBox_ShowProject.Enabled = false;
                CheckBox_ShowType.Enabled = false;
                CheckBox_ShowUser.Enabled = false;
                CheckBox_updateProject.Enabled = false;
                CheckBox_UpdateType.Enabled = false;
                CheckBox_UpdateUser.Enabled = false;
            }
            NumberOfUbdate = dataTableTypes.Rows[Item][2].ToString();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            DataTable NawData = new DataTable();
            NawData = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.PrivetSelectOneOfDataOfUsersByIDType, Class_LinkOfServer.NameOfFildes.IDType, SqlDbType.Int, dataTableTypes.Rows[Item][1].ToString());
            if (dataTableTypes.Rows[Item][1].ToString() != "1" && NawData.Rows.Count == 0)
            {
                nameOfFilde = Class_LinkOfServer.NameOfFildes.IDNo;
                DataType = SqlDbType.Int;
                Data = dataTableTypes.Rows[Item][1].ToString();
                class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.DeleteOfDuteiesOfTypes, Class_LinkOfServer.NameOfFildes.IDType, DataType, Data);
                class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.DeleteOfTypese, nameOfFilde, DataType, Data);
                MessageBox.Show("تمت العملية بنجاح", "تنبيه", MessageBoxButtons.OK);
                dataTableTypes = new DataTable();
                dataTableTypes = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
                if (Item == dataTableTypes.Rows.Count)
                {
                    Item -= 1;
                }
                FormLoad();
            }
            else if (dataTableTypes.Rows[Item][1].ToString() == "1")
            {
                MessageBox.Show("لا يمكنك حذف النوع الرئيسي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("لا يمكنك حذف نوع مستخدم من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text != "" && TextBox_Number.Text != "")
            {
                nameOfFildes = new Class_LinkOfServer.NameOfFildes[3];
                DataTypes = new SqlDbType[3];
                Datas = new string[3];
                nameOfFildes[0] = Class_LinkOfServer.NameOfFildes.IDNo;
                nameOfFildes[1] = Class_LinkOfServer.NameOfFildes.Number;
                nameOfFildes[2] = Class_LinkOfServer.NameOfFildes.FirstName;
                DataTypes[0] = SqlDbType.Int;
                DataTypes[1] = SqlDbType.NVarChar;
                DataTypes[2] = SqlDbType.NVarChar;
                Datas[1] = TextBox_Number.Text;
                Datas[2] = TextBox_Name.Text;
                if (Class_Public.state == Class_Public.State.Add)
                {
                    DataTable MAX = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectMaxOfIDNoDataOfTypese);
                    Datas[0] = (Convert.ToInt32(MAX.Rows[0][0].ToString()) + 1).ToString();
                    class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfTypese, nameOfFildes, DataTypes, Datas);

                    Item = dataTableTypes.Rows.Count;
                }
                else if (Class_Public.state == Class_Public.State.Update)
                {
                    Datas[0] = NumberOfUbdate;
                    class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.UpdateOfTypese, nameOfFildes, DataTypes, Datas);
                    if (CheckBox_AddProject.Enabled != false)
                    {
                        DataType = SqlDbType.Int;
                        class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.DeleteOfDuteiesOfTypes, Class_LinkOfServer.NameOfFildes.IDType, DataType, Datas[0]);
                    }
                }
                if (CheckBox_AddProject.Enabled != false)
                {
                    if (CheckBox_AddUser.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "1";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_UpdateUser.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "2";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_AddProject.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "3";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_updateProject.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "4";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_ShowProject.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "5";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_DeleteUser.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "6";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_ShowUser.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "7";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_DeleteProject.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "8";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_AddType.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "9";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_UpdateType.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "10";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_DeleteType.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "11";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                    if (CheckBox_ShowType.Checked == true)
                    {
                        Class_LinkOfServer.NameOfFildes[] names = new Class_LinkOfServer.NameOfFildes[2];
                        SqlDbType[] types = new SqlDbType[2];
                        string[] Deta = new string[2];
                        names[0] = Class_LinkOfServer.NameOfFildes.IDDuty;
                        names[1] = Class_LinkOfServer.NameOfFildes.IDType;
                        types[0] = SqlDbType.Int;
                        types[1] = SqlDbType.Int;
                        Deta[0] = "12";
                        Deta[1] = Datas[0];
                        class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfDuteiesOfTypes, names, types, Deta);
                    }
                }
                MessageBox.Show("تمت العملية بنجاح", "تنبيه", MessageBoxButtons.OK);
                dataTableTypes = new DataTable();
                dataTableTypes = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
                FormLoad();
            }
            else
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox_AddUser_CheckedChanged(object sender, EventArgs e)
        {
            if(Class_Public.state!=Class_Public.State.Show)
            {
                if (CheckBox_AddUser.Checked == true)
                {
                    CheckBox_ShowUser.Checked = true;
                }
            }
        }

        private void CheckBox_UpdateUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_UpdateUser.Checked == true)
                {
                    CheckBox_ShowUser.Checked = true;
                }
            }
        }

        private void CheckBox_DeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_DeleteUser.Checked == true)
                {
                    CheckBox_ShowUser.Checked = true;
                }
            }
        }

        private void CheckBox_AddType_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_AddType.Checked == true)
                {
                    CheckBox_ShowType.Checked = true;
                }
            }
        }

        private void CheckBox_UpdateType_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_UpdateType.Checked == true)
                {
                    CheckBox_ShowType.Checked = true;
                }
            }
        }

        private void CheckBox_DeleteType_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_DeleteType.Checked == true)
                {
                    CheckBox_ShowType.Checked = true;
                }
            }
        }

        private void CheckBox_AddProject_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_AddProject.Checked == true)
                {
                    CheckBox_ShowProject.Checked = true;
                }
            }
        }

        private void CheckBox_updateProject_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_updateProject.Checked == true)
                {
                    CheckBox_ShowProject.Checked = true;
                }
            }
        }

        private void CheckBox_DeleteProject_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_DeleteProject.Checked == true)
                {
                    CheckBox_ShowProject.Checked = true;
                }
            }
        }

        private void CheckBox_ShowUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_ShowUser.Checked == false)
                {
                    CheckBox_AddUser.Checked = false;
                    CheckBox_UpdateUser.Checked = false;
                    CheckBox_DeleteUser.Checked = false;
                }
            }
        }

        private void CheckBox_ShowType_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_ShowType.Checked == false)
                {
                    CheckBox_AddType.Checked = false;
                    CheckBox_UpdateType.Checked = false;
                    CheckBox_DeleteType.Checked = false;
                }
            }
        }

        private void CheckBox_ShowProject_CheckedChanged(object sender, EventArgs e)
        {
            if (Class_Public.state != Class_Public.State.Show)
            {
                if (CheckBox_ShowProject.Checked == false)
                {
                    CheckBox_AddProject.Checked = false;
                    CheckBox_updateProject.Checked = false;
                    CheckBox_DeleteProject.Checked = false;
                }
            }
        }
    }
}
