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
    public partial class Register : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Register()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Staff ([ID],[Password]) VALUES (@id,@pass)";
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Password Tidak sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Register Sukses");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Staff ([ID],[Password]) VALUES (@id,@pass)";
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Password Tidak sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Register Sukses, silahkan login");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
