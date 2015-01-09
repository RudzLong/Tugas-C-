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
    public partial class GantiPass : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public GantiPass()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void GantiPass_Load(object sender, EventArgs e)
        {
            label2.Text=Status.user;
            groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cekpass;
                connection.Open();
                string query = "Select Password FROM Staff Where ID=@1";
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@1", label2.Text);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cekpass = reader.GetString(0);
                    if(cekpass != textBox1.Text)
                    {
                        MessageBox.Show("Password salah");
                    }
                    else
                    {
                        MessageBox.Show("Password benar");
                        groupBox2.Show();
                    }
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Konfirmasi" + ex);
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Staff SET [Password]=@1 WHERE ID=@2";
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", label2.Text);
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Password Tidak sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ganti Password Sukses");
                    this.Hide();
                    Profile pf = new Profile();
                    pf.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error ganti Pass");
            }
            connection.Close();
        }
    }
}
