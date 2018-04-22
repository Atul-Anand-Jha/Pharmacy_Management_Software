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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cBox_Item.Text = "";
            txt_Manufacturer.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Storage_DB cDB = new Storage_DB();
            cDB.Item = cBox_Item.Text;
            cDB.Manufacturer = txt_Manufacturer.Text;
            cDB.Quantity = txt_Quantity.Text;
            cDB.Price = txt_Price.Text;
            cDB.addproduct(cDB);  
            MessageBox.Show("New Product Added");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Storage_DB cDB = new Storage_DB();
            cDB.Item = cBox_Item.Text;
            cDB.deleteproduct(cDB);
            MessageBox.Show("One Product Deleted");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_message.Text = "You Selected " + cBox_Item.Text;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            Storage_DB cDB = new Storage_DB();
            cDB.fillcombobox(cBox_Item);
        }
    }
}
