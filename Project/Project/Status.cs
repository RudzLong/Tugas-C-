using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Project
{
    class Status
    {
        public static string user;
        public static Boolean status;
        public static bool Hak()
        {
            bool tmp = false;
            OleDbConnection connectin = new OleDbConnection();
            connectin.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Long\Documents\TugasC#.accdb;
Persist Security Info=False;";
            connectin.Open();
            string query = "Select Priveleges FROM Staff Where ID='" + user + "'";
            OleDbCommand cmd = new OleDbCommand(query,connectin);
            OleDbDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                tmp = reader.GetBoolean(0);
            }
            connectin.Close();
            return tmp;
        }
    }
}
