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
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
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
                Status.cek = true;
                MessageBox.Show("Insert Data Dosen Sukses");
                this.Hide();
                Dosen dos = new Dosen();
                this.Hide();
                dos.Show();
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR INSERT" + ex);
            }
            connection.Close();
        }

        private void AddDosen_Load(object sender, EventArgs e)
        {
            label6.Text = "WELCOME" + Status.user;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Status.NID = textBox1.Text;
            if(Status.untukUpdateDosen()== true)
            {
                MessageBox.Show("NID ini sudah ada");
                    button4.Enabled=false;
                    maskedTextBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
            }
            else if (Status.untukUpdateDosen() == false)
            {
                maskedTextBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profil = new Profile();
            this.Hide();
            profil.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
