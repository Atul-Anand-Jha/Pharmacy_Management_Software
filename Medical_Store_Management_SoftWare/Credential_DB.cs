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

    class Credential_DB
    {
        public string Name
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string UserType
        {
            get;
            set;
        }
        public bool Authenticate(Credential_DB cDB)
        {
            string query = String.Format("select * from UserDetails where name = '{0}' and username = '{1}' and password ='{2}' and usertype ='{3}'", cDB.Name, cDB.UserName, cDB.Password, cDB.UserType);
            Business_Logic BL = new Business_Logic();
            OleDbDataReader rec = BL.SelectQuery(query);
            if (rec.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void createnewuser(Credential_DB cDB)
        {
            string query = String.Format("Insert into UserDetails Values('{0}','{1}','{2}', '{3}')", cDB.Name, cDB.UserName, cDB.Password, cDB.UserType);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }
        public void changemypassword(Credential_DB cDB)
        {
            string query = String.Format("UPDATE [UserDetails] SET [PASSWORD] = '{0}' WHERE [USERNAME] = '{1}' AND [USERTYPE] = '{2}' ", cDB.Password, cDB.UserName, cDB.UserType);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);

        }
        public void fillcombobox(ComboBox CB)
        {
            string query = "select username from UserDetails where usertype= 'Staff'"; //direct query so , simply used.
            Business_Logic BL = new Business_Logic();
            OleDbDataReader rec = BL.SelectQuery(query); // datareader only fetches one record at a time, so loop used.
            while (rec.Read())
            {
                CB.Items.Add(rec[0].ToString());
            }


        }
        public void deleteuser(Credential_DB cDB)
        {
            string query = String.Format("delete from UserDetails where username = '{0}'", cDB.UserName);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }

        public void FillGrid(DataGridView GV)
        {
            string query = "select * from UserDetails";
            Business_Logic BBL = new Business_Logic();
            DataSet ds = BBL.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
    }
}
