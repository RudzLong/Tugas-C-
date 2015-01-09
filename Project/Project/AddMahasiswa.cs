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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox3.Items.Remove("TI-A");
                comboBox3.Items.Remove("TI-B");
                comboBox3.Items.Add("SI-A");
                comboBox3.Items.Add("SI-B");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox3.Items.Add("TI-A");
                comboBox3.Items.Add("TI-B");
                comboBox3.Items.Remove("SI-A");
                comboBox3.Items.Remove("SI-B");
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Mahasiswa ([NIM],[Nama],[Jurusan],[Semester],[Kelas],[KetuaJurusan],[WakilKetuaJurusan],[Tanggal Masuk]) VALUES (@nim,@nama,@jurusan,@smster,@kelas,@kejur,@wajur,@tglmsk)";
                command.Parameters.Add("@nim", OleDbType.Numeric).Value = textBox1.Text;
                command.Parameters.Add("@nama", OleDbType.VarChar).Value=textBox2.Text;
                command.Parameters.Add("@jurusan", OleDbType.VarChar).Value=comboBox1.SelectedItem.ToString();
                command.Parameters.Add("@smster", OleDbType.VarChar).Value=comboBox2.SelectedItem.ToString();
                command.Parameters.Add("@kelas", OleDbType.VarChar).Value=comboBox3.SelectedItem.ToString();
                command.Parameters.Add("@kejur", OleDbType.VarChar).Value=comboBox4.SelectedItem.ToString();
                command.Parameters.Add("@wajur", OleDbType.VarChar).Value=comboBox5.SelectedItem.ToString();
                command.Parameters.AddWithValue("@tglmsk", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                Status.cek = true;
                MessageBox.Show("Insert Data Dosen Sukses");
                this.Hide();
                Dosen dos = new Dosen();
                this.Hide();
                dos.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }
    }
}
