using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection(); 
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Long\Documents\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Staff WHERE ID='"+textBox1.Text+"'and Password='"+textBox2.Text+"'";
                OleDbDataReader reader = command.ExecuteReader();
                int hitung = 0;
                while(reader.Read())
                {
                    if(textBox1.Text ==reader.GetString(0) && textBox2.Text == reader.GetString(1))
                    {
                        hitung = 1;
                        Status.status = true;
                        Status.user = textBox1.Text;
                        break;
                    }

                }
                if(hitung==1)
                {
                    MessageBox.Show("ID PAssword sudah benar");
                    //Profile profile = new Profile();
                    //this.Hide();
                    //profile.Show();
                    //AddDosen ad = new AddDosen();
                    //this.Hide();
                    //ad.Show();
                    EditDosen ed = new EditDosen();
                    this.Hide();
                    ed.Show();
                }
                else if(hitung>1)
                {
                    MessageBox.Show("DATABASE ANDA ADA DUPLIKAT");
                }
                else
                {
                    MessageBox.Show("ID PASSWORD TIDAK SAMA");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Error Account"+ x);
            }
            connection.Close();
        }
    }
}
