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
    public partial class AddDosen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AddDosen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Long\Documents\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO DosenList ([NID],[Nama],[Kelas Mengajar],[Semester],[Jurusan],[Tanggal Masuk]) VALUES (@nid,@nama,@kelas,@smster,@jurusan,@tglmsk)";
                command.Parameters.Add("@nid",OleDbType.Numeric).Value=textBox1.Text;
                command.Parameters.AddWithValue("@nama", textBox2.Text);
                command.Parameters.AddWithValue("@kelas", comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue("@smster", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@jurusan", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@tglmsk", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Insert Data Dosen Sukses");
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR INSERT");
            }
            connection.Close();
        }

        private void AddDosen_Load(object sender, EventArgs e)
        {
            label6.Text = "WELCOME" + Status.user;
        }
    }
}
