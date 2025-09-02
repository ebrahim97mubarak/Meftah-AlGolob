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
    public partial class Form_Main : Form
    {
        Enter enter;
        void FormLoad()
        {
            if (Class_Public.NumberOfUser == null || Class_Public.NumberOfUser == "")
            {
                this.Close();
                return;
            }
            Class_Public.Propreties = new string[Class_Public.dataTableOfPropretesOfUser.Rows.Count];
            TSMI_Users.Enabled = false;
            TSMI_Projects.Enabled = false;
            TSMI_Types.Enabled = false;
            for (int i = 0; i < Class_Public.dataTableOfPropretesOfUser.Rows.Count; i++)
            {
                Class_Public.Propreties[i] = Class_Public.dataTableOfPropretesOfUser.Rows[i][1].ToString();
            }
            
            for (int i = 0; i < Class_Public.Propreties.Length; i++)
            {
                if (Class_Public.Propreties[i] == "7")
                {
                    TSMI_Users.Enabled = true;
                }
                else if (Class_Public.Propreties[i] == "5")
                {
                    TSMI_Projects.Enabled = true;
                }
                else if (Class_Public.Propreties[i] == "12")
                {
                    TSMI_Types.Enabled = true;
                }
            }
        }
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class_LinkOfServer class_LinkOfServer = new Class_LinkOfServer();
            class_LinkOfServer.sqlConnection.Open();
            class_LinkOfServer.sqlConnection.Close();
            enter = new Enter();
            enter.ShowDialog();
            FormLoad();
        }

        private void TSMI_Users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void TSMI_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_Cancel_Click(object sender, EventArgs e)
        {
            Class_Public.dataTableOfPropretesOfUser = null;
            Class_Public.Propreties = new string[0];
            Class_Public.NumberOfUser = "";
            Class_Public.User = null;
            enter = new Enter();
            enter.ShowDialog();
            FormLoad();
        }

        private void TSMI_Types_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            types.ShowDialog();
        }
    }
}
