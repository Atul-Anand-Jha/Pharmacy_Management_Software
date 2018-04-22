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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            Transaction_DB cTR = new Transaction_DB();
           /* label5.Text = cTR.CustomerName;
            label6.Text = cTR.Mobile;
            label7.Text = cTR.PurchaseDate;
            label8.Text = cTR.TotalBill;
            * */
            CurrentTransaction_DB TR = new CurrentTransaction_DB();
            dataGridView1.AutoGenerateColumns = true;
            TR.FillGrid(dataGridView1);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bill Printing.........");
        }
    }
}
