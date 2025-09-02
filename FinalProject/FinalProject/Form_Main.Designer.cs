namespace FinalProject
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Types = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_What = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_What,
            this.TSMI_Close});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(846, 24);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Users,
            this.TSMI_Projects,
            this.TSMI_Types,
            this.TSMI_Cancel});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(42, 20);
            this.TSMI_File.Text = "ملف";
            // 
            // TSMI_Users
            // 
            this.TSMI_Users.Name = "TSMI_Users";
            this.TSMI_Users.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Users.Text = "حسابات مستخدمين";
            this.TSMI_Users.Click += new System.EventHandler(this.TSMI_Users_Click);
            // 
            // TSMI_Projects
            // 
            this.TSMI_Projects.Name = "TSMI_Projects";
            this.TSMI_Projects.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Projects.Text = "التجارب";
            // 
            // TSMI_Types
            // 
            this.TSMI_Types.Name = "TSMI_Types";
            this.TSMI_Types.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Types.Text = "الأنواع";
            this.TSMI_Types.Click += new System.EventHandler(this.TSMI_Types_Click);
            // 
            // TSMI_Cancel
            // 
            this.TSMI_Cancel.Name = "TSMI_Cancel";
            this.TSMI_Cancel.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Cancel.Text = "الخروج من الحساب الحالي";
            this.TSMI_Cancel.Click += new System.EventHandler(this.TSMI_Cancel_Click);
            // 
            // TSMI_What
            // 
            this.TSMI_What.Name = "TSMI_What";
            this.TSMI_What.Size = new System.Drawing.Size(79, 20);
            this.TSMI_What.Text = "حول البرنامج";
            // 
            // TSMI_Close
            // 
            this.TSMI_Close.Name = "TSMI_Close";
            this.TSMI_Close.Size = new System.Drawing.Size(101, 20);
            this.TSMI_Close.Text = "حروج من البرنامج";
            this.TSMI_Close.Click += new System.EventHandler(this.TSMI_Close_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 389);
            this.Controls.Add(this.MenuStrip_Main);
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Users;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Projects;
        private System.Windows.Forms.ToolStripMenuItem TSMI_What;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Close;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Types;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cancel;
    }
}