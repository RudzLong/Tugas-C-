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
    public partial class Dosen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Dosen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDosen addDosen = new AddDosen();
            addDosen.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                dataGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From DosenList";
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

        private void button2_Click(object sender, EventArgs e)
        {
            EditDosen ed = new EditDosen();
            this.Hide();
            ed.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Show();
                string query = "DELETE DosenList.NID, DosenList.* FROM DosenList WHERE (((DosenList.NID)=@1));";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@1", textBox1.Text);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * From DosenList";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Delete Data Dosen Sukses");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Delete");
            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dosen_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            button4.Hide();
            dataGridView1.Hide();
            if(Status.cek==true)
            {
                dataGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From DosenList";
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            button4.Show();
            label1.Show();
            button5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Show();
        }
    }
}
