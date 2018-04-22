namespace Medical_Store_Management_SoftWare
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cBox_SelectUser = new System.Windows.Forms.ComboBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Name.Location = new System.Drawing.Point(12, 39);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(113, 21);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Select User :";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Delete.Location = new System.Drawing.Point(92, 105);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cBox_SelectUser
            // 
            this.cBox_SelectUser.FormattingEnabled = true;
            this.cBox_SelectUser.Location = new System.Drawing.Point(157, 42);
            this.cBox_SelectUser.Name = "cBox_SelectUser";
            this.cBox_SelectUser.Size = new System.Drawing.Size(121, 21);
            this.cBox_SelectUser.TabIndex = 3;
            this.cBox_SelectUser.SelectedIndexChanged += new System.EventHandler(this.cBox_SelectUser_SelectedIndexChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(89, 73);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 4;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(290, 155);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.cBox_SelectUser);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cBox_SelectUser;
        private System.Windows.Forms.Label lbl_message;
    }
}