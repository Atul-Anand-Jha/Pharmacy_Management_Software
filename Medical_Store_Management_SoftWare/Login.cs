using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Store_Management_SoftWare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.Name = txt_name.Text;
            cDB.UserName = txt_username.Text;
            cDB.Password = txt_password.Text;
            if (rbtn_owner.Checked)
            {
                cDB.UserType = "Owner";
                
            }
            else if (rbtn_staff.Checked)
            {
                cDB.UserType = "Staff";
            }
            if (cDB.Authenticate(cDB))
            {
                Home hform = new Home();

                hform.lbl_GetIDhere.Text = txt_username.Text;
                hform.lbl_GetUsertype.Text = cDB.UserType;
                txt_password.Text = "";
                hform.Show();
               
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            rbtn_owner.Checked = false;
            rbtn_staff.Checked = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp sgn = new SignUp(txt_name.Text, txt_username.Text, txt_password.Text, rbtn_owner.Checked, rbtn_staff.Checked);
            sgn.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
           /* 
            // for Auto-Filling of form layouts and boxes.
            
            txt_name.Text = "Atul";
            txt_username.Text = "A_anand";
            txt_password.Text = "00000";
            rbtn_owner.Checked = true;
            */
        }
    }
}
