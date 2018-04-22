using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace Medical_Store_Management_SoftWare
{
    class Business_Logic
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public void OpenConnection()
        {
            string constring = ConfigurationManager.ConnectionStrings["constr"].ToString();
            //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Dotnet_DataBase/Database.accdb";
            cn = new OleDbConnection(constring);
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void CloseConnection()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public OleDbDataReader SelectQuery(string query)
        {
            OpenConnection();
            cmd = new OleDbCommand(query, cn);             // we can pass queries
            OleDbDataReader rec = cmd.ExecuteReader();
            return rec;
        }
        public void NonQuery(string query)
        {
            OpenConnection();
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataSet Adapter(string query)
        {
            OpenConnection();
            cmd = new OleDbCommand(query, cn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            CloseConnection();  //"disconnected database access". database only connected when used.
            return ds;
        }
    }
}
