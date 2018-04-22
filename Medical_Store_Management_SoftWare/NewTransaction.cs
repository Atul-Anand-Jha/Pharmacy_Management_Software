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
    public partial class NewTransaction : Form
    {
        int sum = 0;
        public NewTransaction()
        {
            
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {
            
            lbl_ShowDate.Text = DateTime.Now.ToString();
            Storage_DB sDB = new Storage_DB();
            sDB.fillcombobox(cBox_Item);
          
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            dataGridView1.AutoGenerateColumns = true;
            cTR.FillGrid(dataGridView1);
          
            
        }

        private void cBox_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_Quantity.Items.Clear();
            Storage_DB sDB = new Storage_DB();
            sDB.fillcomboboxquantity(cBox_Quantity, cBox_Item.Text);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            int price = cTR.getprice(cBox_Item.Text);
            int paid = price * (Convert.ToInt32(cBox_Quantity.Text));
            cTR.Item = cBox_Item.Text;
            cTR.Quantity = cBox_Quantity.Text;
            cTR.Price = price.ToString();
            cTR.PayPrice = paid.ToString();
            cTR.addtransaction(cTR);
           // dataGridView1.AutoGenerateColumns = true;
            //cTR.FillGrid(dataGridView1);

            sum = sum + paid;
            lbl_ShowBill.Text = sum.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            cTR.Item = cBox_Item.Text;
            cTR.deletetransaction(cTR);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            Transaction_DB tr = new Transaction_DB();
            int price = cTR.getprice(cBox_Item.Text);
            int paid = price * (Convert.ToInt32(cBox_Quantity.Text));
            sum = sum + paid;
             
            tr.CustomerName = txt_Name.Text;
            tr.Mobile = txt_Mobile.Text;
            tr.PurchaseDate = lbl_ShowDate.Text;
            tr.TotalBill = sum.ToString();
            tr.addtransaction(tr);
            Bill b = new Bill();
            b.label5.Text = tr.CustomerName;
            b.label6.Text = tr.Mobile;
            b.label7.Text = tr.PurchaseDate;
            b.label8.Text = tr.TotalBill;
            b.Show();
            cTR.empty();
        }      
    }
}
