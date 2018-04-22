namespace Medical_Store_Management_SoftWare
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cBox_UserType = new System.Windows.Forms.ComboBox();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Name.Location = new System.Drawing.Point(181, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // cBox_UserType
            // 
            this.cBox_UserType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cBox_UserType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cBox_UserType.FormattingEnabled = true;
            this.cBox_UserType.Items.AddRange(new object[] {
            "Owner",
            "Staff"});
            this.cBox_UserType.Location = new System.Drawing.Point(181, 189);
            this.cBox_UserType.Name = "cBox_UserType";
            this.cBox_UserType.Size = new System.Drawing.Size(121, 21);
            this.cBox_UserType.TabIndex = 2;
            this.cBox_UserType.SelectedIndexChanged += new System.EventHandler(this.cBox_UserType_SelectedIndexChanged);
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(93, 234);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(124, 37);
            this.btn_CreateUser.TabIndex = 3;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(27, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Pass :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(27, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Type:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_UserName.Location = new System.Drawing.Point(181, 80);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(121, 20);
            this.txt_UserName.TabIndex = 8;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Password.Location = new System.Drawing.Point(181, 117);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '^';
            this.txt_Password.Size = new System.Drawing.Size(121, 20);
            this.txt_Password.TabIndex = 9;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(181, 155);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '&';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(121, 20);
            this.txt_ConfirmPassword.TabIndex = 10;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(337, 283);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.cBox_UserType);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cBox_UserType;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
    }
}