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
    public partial class EditMhs : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public EditMhs()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void EditMhs_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select Nama FROM DosenList";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox4.Items.Add(reader[0].ToString());
                    comboBox5.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Combobox Error");
            }
            connection.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Status.NIM = textBox1.Text;
            if (Status.untukUpdateMHS() == false)
            {
                MessageBox.Show("NIM TIDAK ADA");
                radButton1.Enabled = false;
            }
            else if (Status.untukUpdateMHS() == true)
            {
                radButton1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Mahasiswa SET [Nama]=@1, [Jurusan]=@2, [Semester]=@3, [Kelas]=@4, [KetuaJurusan]=@5, [WakilKetuaJurusan]=@6, [Tanggal Masuk]=@7 WHERE [NIM]=@8";
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@3", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@4", comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue("@5", comboBox4.SelectedItem.ToString());
                command.Parameters.AddWithValue("@6", comboBox5.SelectedItem.ToString());
                command.Parameters.AddWithValue("@7", maskedTextBox1.Text);
                command.Parameters.Add("@8", OleDbType.Numeric).Value = textBox1.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Update Data Mahasiswa Sukses");
                this.Hide();
                Mahasiswa mhs = new Mahasiswa();
                mhs.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Edit");
            }
            connection.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Mahasiswa SET [Nama]=@1, [Jurusan]=@2, [Semester]=@3, [Kelas]=@4, [KetuaJurusan]=@5, [WakilKetuaJurusan]=@6, [Tanggal Masuk]=@7 WHERE [NIM]=@8";
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@3", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@4", comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue("@5", comboBox4.SelectedItem.ToString());
                command.Parameters.AddWithValue("@6", comboBox5.SelectedItem.ToString());
                command.Parameters.AddWithValue("@7", maskedTextBox1.Text);
                command.Parameters.Add("@8", OleDbType.Numeric).Value = textBox1.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Update Data Mahasiswa Sukses");
                this.Hide();
                Mahasiswa mhs = new Mahasiswa();
                mhs.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Edit");
            }
            connection.Close();
        }
    }
}
