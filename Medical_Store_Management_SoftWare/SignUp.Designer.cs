namespace Medical_Store_Management_SoftWare
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lbl_confirmpassword = new System.Windows.Forms.Label();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_confirmpassword
            // 
            this.lbl_confirmpassword.AutoSize = true;
            this.lbl_confirmpassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpassword.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_confirmpassword.Location = new System.Drawing.Point(36, 34);
            this.lbl_confirmpassword.Name = "lbl_confirmpassword";
            this.lbl_confirmpassword.Size = new System.Drawing.Size(136, 18);
            this.lbl_confirmpassword.TabIndex = 0;
            this.lbl_confirmpassword.Text = "Confirm Password :";
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(201, 34);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.PasswordChar = '#';
            this.txt_confirmpassword.Size = new System.Drawing.Size(198, 20);
            this.txt_confirmpassword.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(149, 80);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 124);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.lbl_confirmpassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_confirmpassword;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Button btn_submit;
    }
}