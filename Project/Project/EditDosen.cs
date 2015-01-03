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
    public partial class EditDosen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public EditDosen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE DosenList SET [Nama]=@1, [Kelas Mengajar]=@2, [Semester]=@3, [Jurusan]=@4, [Tanggal Masuk]=@5 WHERE [NID]=@6";              
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue("@3", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@4", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@5", maskedTextBox1.Text);
                command.Parameters.Add("@6",OleDbType.Numeric).Value=textBox1.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Update Data Dosen Sukses");
                this.Hide();
                Dosen dosen = new Dosen();
                dosen.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR Update");
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dosen dsn = new Dosen();
            dsn.Show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Status.NID = textBox1.Text;
            if (Status.untukUpdateDosen() == false)
            {
                MessageBox.Show("NID TIDAK ADA");
                button4.Enabled = false;
            }
            else if(Status.untukUpdateDosen() == true)
            {
                button4.Enabled = true;
            }
        }

        
    }
}
