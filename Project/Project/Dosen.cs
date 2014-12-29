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
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Long\Documents\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDosen addDosen = new AddDosen();
            addDosen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT DosenList.* FROM DosenList";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource=dt;
            }
            catch(Exception)
            {
                MessageBox.Show("Error Tabel");
            }
            connection.Close();
=======

>>>>>>> parent of 32b644c... Revert "Penambahan coding dan bbrp form"
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                string query = "DELETE DosenList.NID, DosenList.* FROM DosenList WHERE (((DosenList.NID)=@1))";
=======
                string query = "DELETE FROM DosenList WHERE [NID] ='" + textBox1.Text + "'";
>>>>>>> parent of 32b644c... Revert "Penambahan coding dan bbrp form"
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
<<<<<<< HEAD
                command.Parameters.AddWithValue("@1", textBox1.Text);
=======
>>>>>>> parent of 32b644c... Revert "Penambahan coding dan bbrp form"
                command.ExecuteNonQuery();
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
    }
}
