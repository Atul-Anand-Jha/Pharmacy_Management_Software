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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.UserName = label1.Text;
            cDB.UserType = label2.Text;
            cDB.Password = txt_OldPassword.Text;
            if (cDB.Authenticate(cDB))
            {
                if (txt_NewPassword.Text == txt_Confirmpassword.Text)
                {
                    cDB.Password = txt_NewPassword.Text;
                    cDB.changemypassword(cDB);
                    MessageBox.Show("Password Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Password doesnot match");
                }
            }
            else
            {
                MessageBox.Show("old password is incorrect");

            }
        }
    }
}
