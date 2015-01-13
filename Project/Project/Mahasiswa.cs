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

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            radGridView1.Hide();
            label1.Hide();
            radButton1.Hide();
            textBox1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            radButton3.Hide();
            radButton4.Hide();
            textBox2.Hide();
            textBox3.Hide();
            if (Status.cek == true)
            {
                radGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From Mahasiswa";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radGridView1.DataSource = dt;
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
             radGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From Mahasiswa";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radGridView1.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Tabel");
                }
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
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
                else if (int.Parse(textBox3.Text) >= 80)
                {
                    command.Parameters.AddWithValue("@2", "B");
                }
                else if (int.Parse(textBox3.Text) >= 75)
                {
                    command.Parameters.AddWithValue("@2", "C+");
                }
                else if (int.Parse(textBox3.Text) >= 65)
                {
                    command.Parameters.AddWithValue("@2", "C");
                }
                else if (int.Parse(textBox3.Text) >= 50)
                {
                    command.Parameters.AddWithValue("@2", "D");
                }
                else
                {
                    command.Parameters.AddWithValue("@2", "E");
                }
                command.Parameters.AddWithValue("@3", OleDbType.Numeric).Value = textBox2.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Update Sukses");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }

        private void radMenuItem2_Click3(object sender, EventArgs e)
        {
            PrintMahasiswa p = new PrintMahasiswa();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                Status.NIM = textBox1.Text;
                    string query = "DELETE Mahasiswa.NIM, Mahasiswa.* FROM Mahasiswa WHERE (((Mahasiswa.NIM)=@1));";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@1", textBox1.Text);
                    if (Status.untukUpdateMHS() == true)
                    {
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT * From Mahasiswa";
                        OleDbDataAdapter da = new OleDbDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        radGridView1.DataSource = dt;
                        MessageBox.Show("Delete Data Mahasiswa Sukses");
                    }
                    else
                    {
                        MessageBox.Show("NIM tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMhs em = new EditMhs();
            em.Show();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMahasiswa addmhs = new AddMahasiswa();
            addmhs.Show();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            PrintMahasiswa p = new PrintMahasiswa();
            p.Show();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Show();
            radButton1.Show();
            textBox1.Show();
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            radGridView1.Show();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * From Mahasiswa";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                radGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Tabel");
            }
            connection.Close();
        }

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EditMhs em = new EditMhs();
            em.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Status.NIM = textBox1.Text;
                string query = "DELETE Mahasiswa.NIM, Mahasiswa.* FROM Mahasiswa WHERE (((Mahasiswa.NIM)=@1));";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@1", textBox1.Text);
                if (Status.untukUpdateMHS() == true)
                {
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT * From Mahasiswa";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radGridView1.DataSource = dt;
                    MessageBox.Show("Delete Data Mahasiswa Sukses");
                }
                else
                {
                    MessageBox.Show("NIM tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();    
        }

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            label2.Show();
            textBox2.Show();
            radButton3.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT NIM FROM Mahasiswa";
                Status.NIM = textBox2.Text;
                if (Status.untukUpdateMHS() == false)
                {
                    MessageBox.Show("NIM Tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    textBox3.Visible = true;
                    radButton4.Show();
                    Object value;
                    string query = string.Format("Select [Nama] From Mahasiswa WHERE [NIM]=@1");
                    command.CommandText = query;
                    command.Parameters.Add("@1", OleDbType.VarChar).Value = textBox2.Text;
                    value = command.ExecuteScalar();
                    label4.Text = value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Update Sukses");
            }
            connection.Close();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Update Mahasiswa SET [NilaiAkhir]=@1, [Grade]=@2 WHERE [NIM]=@3";
                command.Parameters.Add("@1", OleDbType.Numeric).Value = textBox3.Text;
                if (int.Parse(textBox3.Text) > 90)
                {
                    command.Parameters.AddWithValue("@2", "A");
                }
                else if (int.Parse(textBox3.Text) >= 85)
                {
                    command.Parameters.AddWithValue("@2", "B+");
                }
                else if (int.Parse(textBox3.Text) >= 80)
                {
                    command.Parameters.AddWithValue("@2", "B");
                }
                else if (int.Parse(textBox3.Text) >= 75)
                {
                    command.Parameters.AddWithValue("@2", "C+");
                }
                else if (int.Parse(textBox3.Text) >= 65)
                {
                    command.Parameters.AddWithValue("@2", "C");
                }
                else if (int.Parse(textBox3.Text) >= 50)
                {
                    command.Parameters.AddWithValue("@2", "D");
                }
                else
                {
                    command.Parameters.AddWithValue("@2", "E");
                }
                command.Parameters.AddWithValue("@3", OleDbType.Numeric).Value = textBox2.Text;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * From Mahasiswa";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                radGridView1.DataSource = dt;
                MessageBox.Show("Update Sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }
    }
}
