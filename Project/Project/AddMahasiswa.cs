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
    public partial class AddMahasiswa : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AddMahasiswa()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void AddMahasiswa_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select Nama FROM DosenList";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    comboBox4.Items.Add(reader[0].ToString());
                    comboBox5.Items.Add(reader[0].ToString());
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Combobox Error");
            }
            connection.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
            this.Hide();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Mahasiswa ([NIM],[Nama],[Jurusan],[Semester],[Kelas],[KetuaJurusan],[WakilKetuaJurusan],[Tanggal Masuk]) VALUES (@nim,@nama,@jurusan,@smster,@kelas,@kejur,@wajur,@tglmsk)";
                command.Parameters.Add("@nim", OleDbType.Numeric).Value = textBox1.Text;
                command.Parameters.Add("@nama", OleDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@jurusan", OleDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
                command.Parameters.Add("@smster", OleDbType.VarChar).Value = comboBox2.SelectedItem.ToString();
                command.Parameters.Add("@kelas", OleDbType.VarChar).Value = comboBox3.SelectedItem.ToString();
                command.Parameters.Add("@kejur", OleDbType.VarChar).Value = comboBox4.SelectedItem.ToString();
                command.Parameters.Add("@wajur", OleDbType.VarChar).Value = comboBox5.SelectedItem.ToString();
                command.Parameters.AddWithValue("@tglmsk", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                Status.cek = true;
                MessageBox.Show("Insert Data Mhs Sukses");
                this.Hide();
                Mahasiswa mhs = new Mahasiswa();
                this.Hide();
                mhs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }
    }
}
