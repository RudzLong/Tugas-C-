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
    public partial class Mahasiswa : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Mahasiswa()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label1.Hide();
            button4.Hide();
            textBox1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button9.Hide();
            button10.Hide();
            textBox2.Hide();
            textBox3.Hide();
            if (Status.cek == true)
            {
                dataGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From Mahasiswa";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Tabel");
                }

                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddMahasiswa addmhs = new AddMahasiswa();
            addmhs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             dataGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From Mahasiswa";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Tabel");
                }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Hide();
            label1.Show();
            button4.Show();
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Show();
            textBox2.Show();
            button9.Show();
            if(Status.Hak()== false)
            {
                button8.Enabled = false;
                MessageBox.Show("Anda hanya bisa add bukan edit");
            }
            else
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT NIM FROM Mahasiswa";
                Status.NIM = textBox2.Text;
                if(Status.untukUpdateMHS()== false)
                {
                    MessageBox.Show("NIM Tidak ada");
                }
                else
                {
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    textBox3.Visible = true;
                    button10.Show();
                    Object value;
                    string query = string.Format("Select [Nama] From Mahasiswa WHERE [NIM]=@1");
                    command.CommandText = query;
                    command.Parameters.Add("@1", OleDbType.VarChar).Value= textBox2.Text;
                    value = command.ExecuteScalar();
                    label4.Text = value.ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Update Sukses");
            }
            connection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Update Mahasiswa SET [NilaiAkhir]=@1, [Grade]=@2 WHERE [NIM]=@3";
                command.Parameters.Add("@1", OleDbType.Numeric).Value = textBox3.Text;
                if(int.Parse(textBox3.Text)>90)
                {
                    command.Parameters.AddWithValue("@2","A");
                }
                else if(int.Parse(textBox3.Text)>=85)
                {
                    command.Parameters.AddWithValue("@2", "B+");
                }
                command.Parameters.AddWithValue("@3", OleDbType.Numeric).Value = textBox2.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Update Sukses");
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            connection.Close();
        }
    }
}
