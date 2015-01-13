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

        private void Dosen_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            radButton1.Hide();
            radGridView1.Hide();
            if(Status.cek==true)
            {
                radGridView1.Show();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * From DosenList";
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

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            PrintDosen p = new PrintDosen();
            p.Show();
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            radGridView1.Show();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * From DosenList";
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

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            AddDosen addDosen = new AddDosen();
            addDosen.Show();
            this.Hide();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            EditDosen ed = new EditDosen();
            this.Hide();
            ed.Show();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Show();
            textBox1.Show();
            radButton1.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Show();
                Status.NID = textBox1.Text;
                string query = "DELETE DosenList.NID, DosenList.* FROM DosenList WHERE (((DosenList.NID)=@1));";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@1", textBox1.Text);
                if (Status.untukUpdateDosen() == true)
                {
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT * From DosenList";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radGridView1.DataSource = dt;
                    MessageBox.Show("Delete Data Dosen Sukses");
                    Dosen dsn = new Dosen();
                    this.Hide();
                    dsn.Show();
                }
                else
                {
                    MessageBox.Show("NID tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
