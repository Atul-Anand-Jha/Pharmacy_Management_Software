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
    public partial class ExistingTransaction : Form
    {
        public ExistingTransaction()
        {
            InitializeComponent();
        }

        private void ExistingTransaction_Load(object sender, EventArgs e)
        {
            Transaction_DB cTR = new Transaction_DB();
            dataGridView1.AutoGenerateColumns = true;
            cTR.FillGrid(dataGridView1);
        }
    }
}
