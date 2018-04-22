using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data; 


namespace Medical_Store_Management_SoftWare
{
    class Transaction_DB
    {
        public string CustomerName
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }
        public string PurchaseDate
        {
            get;
            set;
        }
        public string TotalBill
        {
            get;
            set;
        }
        public void addtransaction(Transaction_DB sDB)
        {
            string query = String.Format("Insert into [Transaction] Values('{0}','{1}','{2}', '{3}')", sDB.CustomerName, sDB.Mobile, sDB.PurchaseDate, sDB.TotalBill);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }


        public void FillGrid(DataGridView GV)
        {
            string query = "select * from [Transaction]";
            Business_Logic BBL = new Business_Logic();
            DataSet ds = BBL.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
    }
}

