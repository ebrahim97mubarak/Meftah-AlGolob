namespace FinalProject
{
    partial class Enter
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Paswoord = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Password2 = new System.Windows.Forms.TextBox();
            this.Label_Password2 = new System.Windows.Forms.Label();
            this.Button_Enter = new System.Windows.Forms.Button();
            this.CheckBox_ControlOfPassword = new System.Windows.Forms.CheckBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(13, 15);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(85, 13);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "اسم المستخدم:";
            // 
            // Label_Paswoord
            // 
            this.Label_Paswoord.AutoSize = true;
            this.Label_Paswoord.Location = new System.Drawing.Point(13, 41);
            this.Label_Paswoord.Name = "Label_Paswoord";
            this.Label_Paswoord.Size = new System.Drawing.Size(63, 13);
            this.Label_Paswoord.TabIndex = 1;
            this.Label_Paswoord.Text = "كلمة المرور:";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(135, 38);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Password.TabIndex = 2;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(135, 12);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(275, 20);
            this.TextBox_Name.TabIndex = 1;
            // 
            // TextBox_Password2
            // 
            this.TextBox_Password2.Location = new System.Drawing.Point(135, 64);
            this.TextBox_Password2.Name = "TextBox_Password2";
            this.TextBox_Password2.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Password2.TabIndex = 3;
            // 
            // Label_Password2
            // 
            this.Label_Password2.AutoSize = true;
            this.Label_Password2.Location = new System.Drawing.Point(13, 67);
            this.Label_Password2.Name = "Label_Password2";
            this.Label_Password2.Size = new System.Drawing.Size(116, 13);
            this.Label_Password2.TabIndex = 1;
            this.Label_Password2.Text = "التحقق من كلمة المرور:";
            // 
            // Button_Enter
            // 
            this.Button_Enter.Location = new System.Drawing.Point(135, 90);
            this.Button_Enter.Name = "Button_Enter";
            this.Button_Enter.Size = new System.Drawing.Size(75, 23);
            this.Button_Enter.TabIndex = 4;
            this.Button_Enter.Text = "الدخول";
            this.Button_Enter.UseVisualStyleBackColor = true;
            this.Button_Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBox_ControlOfPassword
            // 
            this.CheckBox_ControlOfPassword.AutoSize = true;
            this.CheckBox_ControlOfPassword.Location = new System.Drawing.Point(310, 40);
            this.CheckBox_ControlOfPassword.Name = "CheckBox_ControlOfPassword";
            this.CheckBox_ControlOfPassword.Size = new System.Drawing.Size(104, 17);
            this.CheckBox_ControlOfPassword.TabIndex = 5;
            this.CheckBox_ControlOfPassword.Text = "إظهار كلمة المرور";
            this.CheckBox_ControlOfPassword.UseVisualStyleBackColor = true;
            this.CheckBox_ControlOfPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ControlOfPassword_CheckedChanged);
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(229, 90);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "الخروج";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Enter
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 123);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBox_ControlOfPassword);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Enter);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_Password2);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Label_Password2);
            this.Controls.Add(this.Label_Paswoord);
            this.Controls.Add(this.Label_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الدخول";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Paswoord;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_Password2;
        private System.Windows.Forms.Label Label_Password2;
        private System.Windows.Forms.Button Button_Enter;
        private System.Windows.Forms.CheckBox CheckBox_ControlOfPassword;
        private System.Windows.Forms.Button Button_Close;
    }
}