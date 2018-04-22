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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.UserName = cBox_SelectUser.Text;
            cDB.deleteuser(cDB);
            lbl_message.Text = "User Deleted";
        }

        private void cBox_SelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_message.Text = "You Selected " + cBox_SelectUser.Text;
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.fillcombobox(cBox_SelectUser);
        }

       
    }
}
