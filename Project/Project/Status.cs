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
        public static Boolean cek;
        public static string NID;
        public static string NIM;
        public static Boolean untukUpdateMHS()
        {
            bool tmp = false;
            int cekNIM;
            OleDbConnection connectin = new OleDbConnection();
            connectin.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
            connectin.Open();
            string query = "Select NIM FROM Mahasiswa Where NIM=@1";
            OleDbCommand cmd = new OleDbCommand(query, connectin);
            cmd.Parameters.Add("@1", OleDbType.Numeric).Value = NIM;

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cekNIM = reader.GetInt32(0);
                tmp = true;
            }
            connectin.Close();
            return tmp;
        }
        public static Boolean untukUpdateDosen()
        {
            bool tmp = false;
            int cekNID;
            OleDbConnection connectin = new OleDbConnection();
            connectin.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
            connectin.Open();
            string query = "Select NID FROM DosenList Where NID=@1";
            OleDbCommand cmd = new OleDbCommand(query, connectin);
            cmd.Parameters.Add("@1", OleDbType.Numeric).Value = NID;
            
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cekNID = reader.GetInt32(0);
                tmp = true;
            }
            connectin.Close();
            return tmp;
        }
        public static bool Hak()
        {
            bool tmp = false;
            OleDbConnection connectin = new OleDbConnection();
            connectin.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
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
        public static Boolean cekpass()
        {
            bool tmp = false;
            string cekpass;
            OleDbConnection connectin = new OleDbConnection();
            connectin.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
            connectin.Open();
            string query = "Select Password FROM Staff Where ID=@1";
            OleDbCommand cmd = new OleDbCommand(query, connectin);
            cmd.Parameters.AddWithValue("@1", user);

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cekpass = reader.GetString(0);
                tmp = true;
            }
            connectin.Close();
            return tmp;
        }
    }
}
