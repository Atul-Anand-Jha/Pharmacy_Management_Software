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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
           
            NewUser NU = new NewUser();
            NU.MdiParent = this;                    //New user form open inside the home page
            NU.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            
            if (lbl_GetUsertype.Text == "Owner")
            {
                DeleteUser Du = new DeleteUser();
                Du.MdiParent = this;
                Du.Show();
            }
            else
            {
                MessageBox.Show("Administrative rights required to do this operation");
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.label4.Text = lbl_GetIDhere.Text;
            cp.label5.Text = lbl_GetUsertype.Text;
            cp.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
           
            EditProduct EP = new EditProduct();
            EP.MdiParent = this;                    
            EP.Show();
        }

        private void checkStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
           
            Store ST = new Store();
            ST.MdiParent = this;
            ST.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
           
            ViewUser ST = new ViewUser();
            ST.MdiParent = this;
            ST.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            NewTransaction tr = new NewTransaction();
            tr.MdiParent = this;
            tr.Show();
        }

        private void existingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ExistingTransaction ex = new ExistingTransaction();
            ex.MdiParent = this;
            ex.Show();
        }

       
    }
}
