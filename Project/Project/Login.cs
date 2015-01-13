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
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Staff WHERE ID='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int hitung = 0;
                while (reader.Read())
                {
                    if (textBox1.Text == reader.GetString(0) && textBox2.Text == reader.GetString(1))
                    {
                        hitung = 1;
                        Status.status = true;
                        Status.user = textBox1.Text;
                        break;
                    }

                }
                if (hitung == 1)
                {
                    Profile profile = new Profile();
                    this.Hide();
                    profile.Show();
                }
                else if (hitung > 1)
                {
                    MessageBox.Show("Database anda ada DUPLIKAT", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("ID Password Tidak Sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error Account" + x);
            }
            connection.Close();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            CL c = new CL();
            c.Show();
        } 
    }
}
