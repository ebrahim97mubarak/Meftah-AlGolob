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
    public partial class Users : Form
    {
        DataTable dataTableUser;
        DataTable dataTableType;
        Class_LinkOfServer class_LinkOfServer = new Class_LinkOfServer();
        Class_LinkOfServer.NameOfFildes[] nameOfFildes;
        SqlDbType[] TypeOfDatas;
        Class_LinkOfServer.NameOfFildes nameOfFilde;
        SqlDbType TypeOfData;
        string[] Datas;
        string Data;
        int Item = 0;
        string NumberOfUbdate;
        public Users()
        {
            InitializeComponent();
        }
        void TypeOfTools(Boolean Type)
        {
            TextBox_Name.Enabled = Type;
            TextBox_Number.Enabled = Type;
            TextBox_Password.Enabled = Type;
            TextBox_Password2.Enabled = Type;
            TextBox_Telephon.Enabled = Type;
            TextBox_Title.Enabled = Type;
            ComboBox_Type.Enabled = Type;
            Button_Close.Enabled = !Type;
            Button_First.Enabled = !Type;
            Button_Last.Enabled = !Type;
            Button_Next.Enabled = !Type;
            Button_Previw.Enabled = !Type;
            Button_Save.Enabled = Type;
            Button_Cancel.Enabled = Type;
            Button_Add.Enabled = false;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
            for (int i = 0; i < Class_Public.Propreties.Length; i++)
            {
                if (Class_Public.Propreties[i] == "1")
                {
                    Button_Add.Enabled = !Type;
                }
                else if (Class_Public.Propreties[i] == "2")
                {
                    Button_Update.Enabled = !Type;
                }
                else if (Class_Public.Propreties[i] == "6")
                {
                    Button_Delete.Enabled = !Type;
                }
            }
        }
        void FormLoad()
        {
            Class_Public.state = Class_Public.State.Show;
            TypeOfTools(false);
            TextBox_Name.Text = dataTableUser.Rows[Item][3].ToString();
            TextBox_Number.Text = dataTableUser.Rows[Item][2].ToString();
            TextBox_Password.Text = dataTableUser.Rows[Item][4].ToString();
            TextBox_Password.UseSystemPasswordChar = true;
            TextBox_Password2.Text = dataTableUser.Rows[Item][4].ToString();
            TextBox_Password2.UseSystemPasswordChar = true;
            TextBox_Telephon.Text = dataTableUser.Rows[Item][6].ToString();
            TextBox_Title.Text = dataTableUser.Rows[Item][7].ToString();
            ComboBox_Type.DataSource = dataTableType;
            ComboBox_Type.DisplayMember = "FristName";
            ComboBox_Type.ValueMember = "IDNo";
            ComboBox_Type.SelectedValue = dataTableUser.Rows[Item][5];
            Label_PartOfAll.Text = "المستخدم " + (Item + 1).ToString() + " من أصل " + dataTableUser.Rows.Count.ToString();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            Button_Add.Enabled = false;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
            dataTableUser = new DataTable();
            dataTableUser = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfUsers);
            dataTableType = new DataTable();
            dataTableType = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
            FormLoad();
        }

        private void Button_First_Click(object sender, EventArgs e)
        {
            Item = 0;
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
            if (Item != dataTableUser.Rows.Count - 1)
            {
                Item += 1;
                FormLoad();
            }
        }

        private void Button_Last_Click(object sender, EventArgs e)
        {
            Item = dataTableUser.Rows.Count - 1;
            FormLoad();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Class_Public.state = Class_Public.State.Add;
            TypeOfTools(true);
            TextBox_Name.Text = "";
            TextBox_Number.Text = "";
            TextBox_Password.Text = "";
            TextBox_Password2.Text = "";
            TextBox_Telephon.Text = "";
            TextBox_Title.Text = "";
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            Class_Public.state = Class_Public.State.Update;
            TypeOfTools(true);
            if (dataTableUser.Rows[Item][1].ToString() == "1" || dataTableUser.Rows[Item][1].ToString() == Class_Public.NumberOfUser)
            {
                ComboBox_Type.Enabled = false;
            }
            NumberOfUbdate = dataTableUser.Rows[Item][1].ToString();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text != "" && TextBox_Number.Text != "" && TextBox_Password.Text != "" && TextBox_Password2.Text != "" && TextBox_Password.Text == TextBox_Password2.Text && TextBox_Telephon.Text != "" && TextBox_Title.Text != "")
            {
                nameOfFildes = new Class_LinkOfServer.NameOfFildes[7];
                TypeOfDatas = new SqlDbType[7];
                Datas = new string[7];
                nameOfFildes[0] = Class_LinkOfServer.NameOfFildes.IDNo;
                nameOfFildes[1] = Class_LinkOfServer.NameOfFildes.Number;
                nameOfFildes[2] = Class_LinkOfServer.NameOfFildes.FirstName;
                nameOfFildes[3] = Class_LinkOfServer.NameOfFildes.Passwords;
                nameOfFildes[4] = Class_LinkOfServer.NameOfFildes.IDType;
                nameOfFildes[5] = Class_LinkOfServer.NameOfFildes.Telephon;
                nameOfFildes[6] = Class_LinkOfServer.NameOfFildes.Title;
                TypeOfDatas[0] = SqlDbType.Int;
                TypeOfDatas[1] = SqlDbType.NVarChar;
                TypeOfDatas[2] = SqlDbType.NVarChar;
                TypeOfDatas[3] = SqlDbType.NVarChar;
                TypeOfDatas[4] = SqlDbType.Int;
                TypeOfDatas[5] = SqlDbType.NVarChar;
                TypeOfDatas[6] = SqlDbType.NVarChar;
                Datas[1] = TextBox_Number.Text;
                Datas[2] = TextBox_Name.Text;
                Datas[3] = TextBox_Password.Text;
                Datas[4] = ComboBox_Type.SelectedValue.ToString();
                Datas[5] = TextBox_Telephon.Text;
                Datas[6] = TextBox_Title.Text;
                if (Class_Public.state == Class_Public.State.Add)
                {
                    DataTable MAX = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectMaxOfIDNoDataOfUsers);
                    Datas[0] = (Convert.ToInt32(MAX.Rows[0][0].ToString()) + 1).ToString();
                    class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.InsertOfUsers, nameOfFildes, TypeOfDatas, Datas);
                    Item = dataTableUser.Rows.Count;
                }
                else if (Class_Public.state == Class_Public.State.Update)
                {
                    Datas[0] = NumberOfUbdate;
                    class_LinkOfServer.WriteData(Class_LinkOfServer.NameOfStoredProcedure.UpdateOfUsers, nameOfFildes, TypeOfDatas, Datas);
                }
                MessageBox.Show("تمت العملية بنجاح", "تنبيه", MessageBoxButtons.OK);
                dataTableUser = new DataTable();
                dataTableUser = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfUsers);
                dataTableType = new DataTable();
                dataTableType = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
                FormLoad();
            }
            else if (TextBox_Password.Text != TextBox_Password2.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (dataTableUser.Rows[Item][1].ToString()!="1"&& dataTableUser.Rows[Item][1].ToString()!=Class_Public.NumberOfUser)
            {
                nameOfFilde = Class_LinkOfServer.NameOfFildes.IDNo;
                TypeOfData = SqlDbType.Int;
                Data = dataTableUser.Rows[Item][1].ToString();
                class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.DeleteOfUsers, nameOfFilde, TypeOfData, Data);
                MessageBox.Show("تمت العملية بنجاح", "تنبيه", MessageBoxButtons.OK);
                dataTableUser = new DataTable();
                dataTableUser = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfUsers);
                dataTableType = new DataTable();
                dataTableType = class_LinkOfServer.ReadData(Class_LinkOfServer.NameOfStoredProcedure.SelectAllDataOfTypese);
                if(Item==dataTableUser.Rows.Count)
                {
                    Item -= 1;
                }
                FormLoad();
            }
            else if(dataTableUser.Rows[Item][1].ToString() == "1")
            {
                MessageBox.Show("لا يمكنك حذف المستخدم الرئيسي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("لا يمكنك حذف المستخدم الحالي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
